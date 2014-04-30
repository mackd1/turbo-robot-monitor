using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIEM_Project.Classes;
using System.Diagnostics;
using System.IO;

namespace SIEM_Project
{
    public partial class ProcessMonitor : Form
    {
        private List<ProcessInfo> processList;
        private Dictionary<int, ProcessInfo> processDict;
        private DataTable resourceTable;
        private DataManager dataMan;

        public ProcessMonitor()
        {
            InitializeComponent();
        }

        private void ProcessMonitor_Load(object sender, EventArgs e)
        {
            processList = new List<ProcessInfo>();
            processDict = new Dictionary<int, ProcessInfo>();
            resourceTable = new DataTable("resources");
            dataMan = new DataManager();

            InitializeResourcesTable();

            RefreshProcessList();
            refreshTimer.Enabled = true;
        }

        private void RefreshProcessList()
        {
            // Get a list of all currently running processes
            Process[] pList = Process.GetProcesses();

            foreach (KeyValuePair<int, ProcessInfo> pair in processDict)
            {
                // Tag each process as not updated, then remove all processes from the list
                // that are still listed as not updated after the pList has been processed.
                pair.Value.updated = false;
            }

            foreach (Process process in pList)
            {
                // Check if its been loaded already
                if (processDict.ContainsKey(process.Id))
                {
                    // Already in the list, so just update the info
                    processDict[process.Id].numHandles = process.HandleCount;

                    try
                    {
                        processDict[process.Id].numModules = process.Modules.Count;
                    }
                    catch
                    {
                        processDict[process.Id].numModules = 0;
                    }

                    processDict[process.Id].basePriority = process.BasePriority;
                    processDict[process.Id].memUsed = process.PeakWorkingSet64;
                    processDict[process.Id].numThreads = process.Threads.Count;
                    processDict[process.Id].processName = process.ProcessName;
                    processDict[process.Id].cpuTime = process.TotalProcessorTime.Milliseconds;

                    processDict[process.Id].updated = true;

                    // Check status against process history
                    CheckProcessStatus(processDict[process.Id]);
                }
                else
                {
                    // Process not encountered yet, so add it to the dictionary

                    /* This block of code can case the following exceptions
                     *  - Access Denied (for the audiodg process mostly)
                     *  - Process closed (when processes close in the middle)
                     *  - Unable to enumerate modules (causes a module list of 0 */
                    try
                    {
                        ProcessInfo tInfo = new ProcessInfo();

                        tInfo.id = process.Id;

                        tInfo.numHandles = process.HandleCount;
                        tInfo.numModules = process.Modules.Count;
                        tInfo.basePriority = process.BasePriority;
                        tInfo.memUsed = process.PeakWorkingSet64;
                        tInfo.numThreads = process.Threads.Count;
                        tInfo.processName = process.ProcessName;
                        tInfo.cpuTime = process.TotalProcessorTime.Milliseconds;

                        tInfo.updated = true;

                        tInfo.pHistory = GetProcessHistory(process.Id);

                        if (tInfo.pHistory == null)
                        {
                            ProcessHistory tempHistory = new ProcessHistory();

                            tempHistory.avgHandles = 0;
                            tempHistory.avgMemUsed = 0;
                            tempHistory.avgModules = 0;
                            tempHistory.avgProcessorTime = 0;
                            tempHistory.avgThreads = 0;
                            tempHistory.basePriority = 0;
                            tempHistory.name = "no_history";

                            tInfo.pHistory = tempHistory;
                        }

                        processDict.Add(process.Id, tInfo);

                        // TODO::Insert listbox entry
                        processListView.Items.Add(new ListViewItem(process.Id.ToString()));
                        CheckProcessStatus(tInfo);
                    }
                    catch (Exception ex)
                    {
                        // Nothing we can really do about these errors, so ignore for now?
                    }
                }
            }

            List<int> removeList = new List<int>();

            foreach (KeyValuePair<int, ProcessInfo> pair in processDict)
            {
                if (pair.Value.updated == false)
                {
                    removeList.Add(pair.Value.id);

                    removeListItem(pair.Value.id.ToString());
                }
            }
            
            for (int i = 0; i < removeList.Count; i++)
            {
                processDict.Remove(removeList[i]);
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void removeListItem(string key)
        {
            for (int i = 0; i < processListView.Items.Count; i++)
            {
                if (processListView.Items[i].Text.Equals(key))
                {
                    processListView.Items.RemoveAt(i);

                    return;
                }
            }
        }

        private void UpdateProcessInfoPage(ProcessInfo pInfo)
        {
            processNameLbl.Text = "Process Name: " + pInfo.processName;
            modulesLbl.Text = "Modules: " + pInfo.numModules.ToString();
            numThreadsLbl.Text = "Threads: " + pInfo.numThreads.ToString();
            numHandlesLbl.Text = "Handles: " + pInfo.numHandles.ToString();
            memUsedLbl.Text = "Peak mem used: " + (pInfo.memUsed / 1024).ToString() + " kb";
            basePriorityLbl.Text = "Base Priority: " + pInfo.basePriority.ToString();
            cpuTimeLbl.Text = "CPU Time (in ms): " + pInfo.cpuTime.ToString();

            avgModulesLbl.Text = "Average # Modules: " + pInfo.pHistory.avgModules.ToString();
            avgThreadsLbl.Text = "Average # Threads: " + pInfo.pHistory.avgThreads.ToString();
            avgHandlesLbl.Text = "Average # Handles: " + pInfo.pHistory.avgHandles.ToString();
            avgMemUsedLbl.Text = "Avg. Peak mem used: " + (pInfo.pHistory.avgMemUsed / 1024).ToString() + " kb";
            avgBasePriorityLbl.Text = "Avg. Base Priority: " + pInfo.pHistory.basePriority.ToString();
            avgCPUTimeLbl.Text = "Avg. CPU Time (in ms): " + pInfo.pHistory.avgProcessorTime.ToString();
        }

        private void processListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowCount = resourceTable.Rows.Count - 1;

            for (int i = rowCount; i >= 0; i--)
            {
                resourceTable.Rows.RemoveAt(i);
            }

            try
            {
                int pid = Convert.ToInt32(processListView.SelectedItems[0].Text);
                UpdateProcessInfoPage(processDict[pid]);
                Update_ResourcesGrid(pid);                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // This happens apparently, just ignore it.
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private int Update_ResourcesGrid(int pid)
        {
            Process tempProcess = Process.GetProcessById(pid);
            ProcessModuleCollection moduleList = tempProcess.Modules;

            // Iterate through the module collection
            foreach (ProcessModule module in moduleList)
            {
                FileInfo tempFile = new FileInfo(module.FileName.ToString());

                resourceTable.Rows.Add(module.FileVersionInfo.FileName, module.FileVersionInfo.FileVersion,
                    module.ModuleMemorySize, tempFile.LastWriteTime.ToShortDateString(), module.FileVersionInfo.FileDescription,
                    module.FileVersionInfo.ProductName, module.FileVersionInfo.ProductVersion.ToString());
            }

            return moduleList.Count;
        }

        private ProcessHistory GetProcessHistory(int pid)
        {
            return dataMan.GetProcessHistory(Process.GetProcessById(pid).ProcessName);
        }

        private void InitializeResourcesTable()
        {
            DataColumn pathCol = new DataColumn("Module Path");
            DataColumn fileVerCol = new DataColumn("File Version");
            DataColumn fileSizeCol = new DataColumn("File Size");
            DataColumn fileModDateCol = new DataColumn("File Modification Date");
            DataColumn fileDescriptionCol = new DataColumn("File Description");
            DataColumn prodNameCol = new DataColumn("Product Name");
            DataColumn prodVerCol = new DataColumn("Product Version");

            resourceTable.Columns.Add(pathCol);
            resourceTable.Columns.Add(fileVerCol);
            resourceTable.Columns.Add(fileSizeCol);
            resourceTable.Columns.Add(fileModDateCol);
            resourceTable.Columns.Add(fileDescriptionCol);
            resourceTable.Columns.Add(prodNameCol);
            resourceTable.Columns.Add(prodVerCol);

            resourceGridView.DataSource = resourceTable;
        }

        private int FindItemIndex(int pid)
        {
            for (int i = 0; i < processListView.Items.Count; i++)
            {
                if (processListView.Items[i].Text.Equals(pid.ToString()))
                {
                    return i;
                }
            }

            return -1;
        }

        private void CheckProcessStatus(ProcessInfo pInfo)
        {
            int numAbove = 0;
            double variance = .3;

            // Check that the resource usage of this process falls within normal limits
            if (pInfo.memUsed > (pInfo.pHistory.avgMemUsed * variance) + pInfo.pHistory.avgMemUsed)
                numAbove++;

            if (pInfo.cpuTime > (pInfo.pHistory.avgProcessorTime * variance) + pInfo.pHistory.avgProcessorTime)
                numAbove++;

            if (pInfo.numModules > (pInfo.pHistory.avgModules * variance) + pInfo.pHistory.avgModules)
                numAbove++;

            if (pInfo.numThreads > (pInfo.pHistory.avgThreads * variance) + pInfo.pHistory.avgThreads)
                numAbove++;

            if (pInfo.numHandles > (pInfo.pHistory.avgHandles * variance) + pInfo.pHistory.avgHandles)
                numAbove++;

            if (pInfo.basePriority > pInfo.pHistory.basePriority)
                numAbove++;

            if (numAbove >= 4)
            {
                processListView.Items[FindItemIndex(pInfo.id)].BackColor = Color.Red;
                // Process is in the red, so send an alert
                AlertSender.SendMessage("Process " + pInfo.id.ToString() + " (" + pInfo.processName + ") is utilizing more resources than baseline", "Process");
            }
            else if (numAbove >= 3)
                processListView.Items[FindItemIndex(pInfo.id)].BackColor = Color.Yellow;
            else
                processListView.Items[FindItemIndex(pInfo.id)].BackColor = Color.Green;
        }
    }
}

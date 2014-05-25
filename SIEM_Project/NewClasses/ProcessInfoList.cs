using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace SIEM_Project.NewClasses
{
    public partial class ProcessInfoList : UserControl
    {
        public ProcessInfoList()
        {
            InitializeComponent();
        }

        Dictionary<String, ProcessInfo> processList;

        private void ProcessInfoList_Load(object sender, EventArgs e)
        {
            CreateProcessList();


        }

        private void CreateProcessList()
        {
            Process[] currProcessList = Process.GetProcesses();
            ProcessInfo tempProcess = new ProcessInfo();

            processList = new Dictionary<String, ProcessInfo>();

            foreach (Process proc in currProcessList)
            {
                tempProcess.processName = proc.ProcessName;
                tempProcess.id = proc.Id;
                tempProcess.numHandles = proc.HandleCount;
                tempProcess.numModules = proc.Modules.Count;
                tempProcess.numThreads = proc.Threads.Count;
                tempProcess.basePriority = proc.BasePriority;

                processList.Add(proc.ProcessName, tempProcess);
            }
        }

        private void UpdateProcessList()
        {

        }
    }
}

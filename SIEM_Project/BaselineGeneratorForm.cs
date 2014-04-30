using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using SIEM_Project.Classes;

namespace SIEM_Project
{
    public partial class BaselineGeneratorForm : Form
    {
        public BaselineGeneratorForm()
        {
            InitializeComponent();
        }

        private DataManager dataMan;
        private int numSamples = 0;
        private int avgTcpConns = 0;

        private void BaselineGeneratorForm_Load(object sender, EventArgs e)
        {
            ProcessHistoryList.Call_UpdateProcessHistory += new HistoryEvent_UpdateProcess(On_UpdateProcess);

            dataMan = new DataManager();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            DialogResult userResp = userResp = MessageBox.Show("This will erase all previously gathered training data!\n Proceed?", "Warning", MessageBoxButtons.YesNo);
               
            if(userResp.Equals(DialogResult.Yes))
            {
                // Begin sampling information
                ProcessHistoryList.RefreshProcesses();
                sampleTimer.Enabled = true;
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            DialogResult userResp;

            if (numSamples < 20)
            {
                userResp = MessageBox.Show("Only " + numSamples + " were taken, would you like to cancel data collection?", "Alert: Small Training Corpus", MessageBoxButtons.YesNo);

                if (userResp.Equals(DialogResult.Yes))
                {
                    sampleTimer.Enabled = false;
                    MessageBox.Show("Data collection canceled");
                    this.Close();
                    return;
                }
            }

            // Stop the timer, and edit the database
            sampleTimer.Enabled = false;

            // Erase the old training data
            dataMan.DeleteTrainingData();

            // Write the new data
            foreach (ProcessHistory pHistory in ProcessHistoryList.processHistoryList)
            {
                dataMan.InsertProcessHistory(pHistory);
            }

            dataMan.InsertNetworkHistory(avgTcpConns);

            MessageBox.Show("Data collection has completed.");
            this.Close();
        }

        private void On_UpdateProcess(int processHistoryIndex, Process process)
        {
            // Update the new information
            try
            {
                ProcessHistoryList.processHistoryList[processHistoryIndex].avgModules = (ProcessHistoryList.processHistoryList[processHistoryIndex].avgModules + process.Modules.Count) / 2;
                ProcessHistoryList.processHistoryList[processHistoryIndex].avgHandles = (ProcessHistoryList.processHistoryList[processHistoryIndex].avgHandles + process.HandleCount) / 2;
                ProcessHistoryList.processHistoryList[processHistoryIndex].avgThreads = (ProcessHistoryList.processHistoryList[processHistoryIndex].avgThreads + process.Threads.Count) / 2;
                ProcessHistoryList.processHistoryList[processHistoryIndex].basePriority = (ProcessHistoryList.processHistoryList[processHistoryIndex].basePriority + process.BasePriority) / 2;
                ProcessHistoryList.processHistoryList[processHistoryIndex].avgMemUsed = (ProcessHistoryList.processHistoryList[processHistoryIndex].avgMemUsed + process.PeakWorkingSet64) / 2;
                ProcessHistoryList.processHistoryList[processHistoryIndex].avgProcessorTime = (ProcessHistoryList.processHistoryList[processHistoryIndex].avgProcessorTime + process.TotalProcessorTime.Milliseconds) / 2;
            }
            catch
            {

            }
        }

        private int GetNumTcpConns()
        {
            TCPInfo.MIB_TCPROW_OWNER_PID[] tcpConnTable = TCPInfo.GetAllTcpConnections();

            return tcpConnTable.Count();
        }

        private void sampleTimer_Tick(object sender, EventArgs e)
        {
            avgTcpConns = (GetNumTcpConns() + avgTcpConns) / 2;
            numSamplesLbl.Text = (++numSamples).ToString() + " Samples";

            ProcessHistoryList.RefreshProcesses();
        }
    }
}

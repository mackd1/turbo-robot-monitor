using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace SIEM_Project.Classes
{
    // public delegate void HistoryEvent_NewProcess(int tempHistoryIndex);
    public delegate void HistoryEvent_UpdateProcess(int tempHistoryIndex, Process process);
    //public delegate void HistoryEvent_CloseProcess(int tempHistoryIndex);

    public class ProcessHistoryList
    {
        // public static event HistoryEvent_NewProcess Call_NewProcessHistory;
        public static event HistoryEvent_UpdateProcess Call_UpdateProcessHistory;
        //public static event HistoryEvent_CloseProcess Call_CloseProcessHistory;

        public static DataManager dataMan = new DataManager();
        public static List<ProcessHistory> processHistoryList;

        public static void RefreshProcesses()
        {
            // Get a new list of processes
            Process[] tempProcessList = Process.GetProcesses();

            if (processHistoryList == null)
                processHistoryList = new List<ProcessHistory>();

            // List every process as not updated, after updates all remaining will fire an event
            for (int i = 0; i < processHistoryList.Count; i++)
                processHistoryList[i].updated = false;

            // Update the list of processes
            foreach (Process process in tempProcessList)
            {
                int index = GetProcessHistoryByName(process.ProcessName);

                if (index == -1)
                    AddNewProcess(process);
                else
                {
                    processHistoryList[index].updated = true;

                    Call_UpdateProcessHistory(index, process);
                }
            }

            // For every process not updated, fire an event
            //for (int i = 0; i < processHistoryList.Count; i++)
            //    if (processHistoryList[i].updated == false)
            //        Call_CloseProcessHistory(i);
        }
        
        private static void AddNewProcess(Process newProcess)
        {
            ProcessHistory pInfo = new ProcessHistory();

            pInfo.updated = true;
            pInfo.name = newProcess.ProcessName;

            try
            {
                pInfo.SetHistory(newProcess.Modules.Count, newProcess.HandleCount, newProcess.Threads.Count,
                    newProcess.BasePriority, newProcess.PeakWorkingSet64, newProcess.TotalProcessorTime.Milliseconds);
            }
            catch (Exception ex)
            {

            }

            processHistoryList.Add(pInfo);

            // Signal that the new process was added
        }

        public static int GetProcessHistoryByName(string name)
        {
            for(int i = 0; i < processHistoryList.Count; i++)
                if(processHistoryList[i].name.Equals(name))
                    return i;

            return -1;
        }
    }
}

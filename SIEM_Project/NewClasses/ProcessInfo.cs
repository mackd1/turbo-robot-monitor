using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Net;
using System.Timers;
using SIEM_Project.Classes;

namespace SIEM_Project.NewClasses
{

    public delegate void ProcessAdded_Event(Object sender, int pid);
    public delegate void ProcessRemoved_Event(Object sender, int pid);
    public delegate void ProcessUpdated_Event(Object sender, int pid);

    class ProcessInfo
    {
        /* Problems:
         *  - How do I identify which process is which when storing information?
         *    - PIDs change, simple process names are susceptible to change as well.
         *  - How do I ensure that all information is kept up-to-date?
         *    - Both the basic process information and the network info
         *  - How do I merge the network, history and current process information?
         *    - This is probably the biggest problem, ideas?
         *      - Uniquely identify this, smallest subset of data that uniquely idenitfies
         *        would probably be?
         *        - Network info gives PID, good enough for short term usage
         *        - History should use FULL file location e.g. c:\programs\program.exe
         *        - Create a master dictionary of processes based on the info from System.Diagnostics
         *          and use the PID
         *          - Solution: Dictionary of structs, each struct will store a process object
         *            and network information.
         * 
         * Ideas:
         *  - Create a central class for storing process information
         *  - this class should send out an event every time a process changes
         *  - all listening forms should process the event and change the displayed information
         *  - central class should run in background and monitor everything
         */
        public event ProcessAdded_Event processAdded_Handler;
        public event ProcessRemoved_Event processRemoved_Handler;
        public event ProcessUpdated_Event processUpdated_Handler;

        private Dictionary<int, ProcessStruct> processList;

        public ProcessInfo()
        {
            Timer processRefreshTimer = new Timer(Properties.Settings.Default.ProcessUpdateInterval);

            processRefreshTimer.Elapsed += UpdateProcessList;        
        }

        private void UpdateProcessList(object sender, ElapsedEventArgs e)
        {
            // Update the master process dictionary from here
            // raised the corresponding events as necessary

            Process[] pList = Process.GetProcesses();

            foreach(Process tempProc in pList)
            {
                if(processList.ContainsKey(tempProc.Id) == true)
                {
                    ProcessStruct tempStruct = new ProcessStruct();

                    tempStruct.pInfo = tempProc;

                    // Insert network info here

                    processList.Add(tempProc.Id, tempStruct);

                    // Process is already in here, not new
                    // processUpdated_Handler(this, tempProc.Id);
                }
                else
                {
                    // Process is new
                    processAdded_Handler(this, tempProc.Id);
                }
            }

            foreach(ProcessStruct pStruct in processList.Values)
            {

            }
        }

        public struct ProcessStruct
        {
            public Process pInfo;
            public List<NetworkInfoStruct> netInfo;
        }

        public struct NetworkInfoStruct
        {
            public IPAddress localIP;
            public IPAddress remoteIP;
            public int localPort;
            public int remotePort;
            public string connectionState;
        }
    }
}

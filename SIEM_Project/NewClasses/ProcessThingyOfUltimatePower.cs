using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Net;
using SIEM_Project.Classes;

namespace SIEM_Project.NewClasses
{
    class ProcessThingyOfUltimatePower : Process
    {
        public List<NetworkInfoStruct> netInfo;

        /*public Process[] GetProcesses()
        {
            Process[] pList = Process.GetProcesses();
        }*/
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

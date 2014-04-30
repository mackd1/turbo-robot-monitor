using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEM_Project.Classes
{
    class ProcessInfo
    {
        public ProcessHistory pHistory;

        public string processName;
        public int id;

        public int numModules;
        public int numThreads;
        public int numHandles;
        public long memUsed;
        public int basePriority;
        public int cpuTime;

        public bool updated;
    }
}

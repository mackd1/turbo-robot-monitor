using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEM_Project.NewClasses
{
    class ProcessInfo
    {
        // Basic Process Information
        public string processName;
        public int id;

        public int numModules;
        public int numThreads;
        public int numHandles;
        public long memUsed;
        public int basePriority;
        public int cpuTime;

        public bool updated;

        // Process History Information
        //      Baseline Information
        public int avgModules;
        public int avgHandles;
        public int avgThreads;
        public int avgBasePriority;       // Alert if priority increases
        public long avgMemUsed;        // Use peakworkingset64
        public int avgProcessorTime;   // Really not sure about this one

        //      Sampling Information
        public int numSamples;

        public ProcessInfo()
        {
            processName = "";
            id = 0;

            numModules = 0;
            numThreads = 0;
            numHandles = 0;
            memUsed = 0;
            basePriority = 0;
            cpuTime = 0;

            avgModules = 0;
            avgHandles = 0;
            avgThreads = 0;
            avgBasePriority = 0;
            avgMemUsed = 0;
            avgProcessorTime = 0;

            numSamples = 0;
            updated = false;
        }
    }
}

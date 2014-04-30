using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIEM_Project.Classes;

namespace SIEM_Project.Classes
{
    public class ProcessHistory
    {
        public string name;

        // Baseline Information
        public int avgModules;
        public int avgHandles;
        public int avgThreads;
        public int basePriority;       // Alert if priority increases
        public long avgMemUsed;        // Use peakworkingset64
        public int avgProcessorTime;   // Really not sure about this one

        // Sampling Information
        public int numSamples;
        public bool updated;

        public ProcessHistory()
        {
            name = "";

            avgModules = 0;
            avgHandles = 0;
            avgThreads = 0;
            basePriority = 0;
            avgMemUsed = 0;
            avgProcessorTime = 0;

            numSamples = 0;
            updated = false;
        }

        public ProcessHistory(string name)
        {
            this.name = name;

            avgModules = 0;
            avgHandles = 0;
            avgThreads = 0;
            basePriority = 0;
            avgMemUsed = 0;
            avgProcessorTime = 0;

            numSamples = 0;
            updated = false;
        }

        public void SetPID(string name)
        {
            this.name = name;
        }

        public void SetHistory(int avgModules, int avgHandles, int avgThreads, int basePriority, long avgMemUsed, int avgProcessorTime)
        {
            this.avgModules = avgModules;
            this.avgHandles = avgHandles;
            this.basePriority = basePriority;
            this.avgMemUsed = avgMemUsed;
            this.avgProcessorTime = avgProcessorTime;
        }
    }
}

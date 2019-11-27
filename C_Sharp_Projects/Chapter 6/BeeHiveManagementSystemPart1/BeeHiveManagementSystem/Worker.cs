using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Worker
    {
        private string currentJob = null;
        public string CurrentJob
        {
            get { return currentJob; }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked = 0;
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
                
        }

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string jobToBeDone, int shiftsToWork)
        {
            foreach (string job in jobsICanDo)
            {
                if (job == jobToBeDone && CurrentJob == null)
                {
                    this.shiftsToWork = shiftsToWork;
                    currentJob = jobToBeDone;
                    shiftsWorked = 0;
                    return true;
                }   
            }
            return false;
        }

        public bool DidYouFinish()
        {
            ++shiftsWorked;
            if (ShiftsLeft == 0)
            {
                shiftsToWork = 0;
                shiftsWorked = 0; 
                currentJob = null;
                return true;
            } 
            return false;
        }
    }
}

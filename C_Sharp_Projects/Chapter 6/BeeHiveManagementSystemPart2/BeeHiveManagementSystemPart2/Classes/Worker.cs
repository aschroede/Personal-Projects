using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystemPart2
{
    class Worker : Bee
    {
        private const double honeyUnitsPerShiftWorked = 0.65;
        private string currentJob = null;
        public string CurrentJob
        {
            get { return currentJob; }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
                
        }

        public Worker(string[] jobsICanDo, double weightMg) : base(weightMg)
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


        // TODO - remove hacks
        // HACK - this is a sucky hack

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            ++shiftsWorked;
            if (ShiftsLeft == -2)
            {
                shiftsToWork = 0;
                shiftsWorked = 0; 
                currentJob = null;
                return true;
            } 
            return false;
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + (honeyUnitsPerShiftWorked * shiftsWorked);
        }
    }
}

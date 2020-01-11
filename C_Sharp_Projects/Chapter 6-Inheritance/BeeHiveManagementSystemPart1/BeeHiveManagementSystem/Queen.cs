using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
        public bool AssignWork(string jobToBeDone, int shiftsToWork)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(jobToBeDone, shiftsToWork))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            // Example report:
            // Report for shift #20
            // Worker #1 will be done with 'Nectar collector' after this shift
            // Worker #2 finished the job
            // Worker #2 is not working
            // Worker #3 is doing 'Sting patrol' for 3 more shifts
            // Worker #4 is doing 'Baby bee tutoring' for 6 more shifts
            int i = 1;
            string Report = "Report for shift #" + shiftNumber + "\r\n";
            foreach (Worker worker in workers)
            {
                if (worker.DidYouFinish())
                {
                    Report += "Worker #" + i + " finished the job\r\n";
                    Report += "Worker #" + i + " is not working\r\n";    
                }
                else if (worker.ShiftsLeft == 1)
                    Report += "Worker #" + i + " will be done with " + worker.CurrentJob + " after this shift\r\n";
                else if (worker.ShiftsLeft > 1)
                    Report += "Worker #" + i + " is doing " + worker.CurrentJob + " for " + worker.ShiftsLeft + " more shifts\r\n";
                else
                    Report += "Worker #" + i + " is not working\r\n";
                ++i;
               
            }
            ++shiftNumber;
            return Report;
        }
    }
}

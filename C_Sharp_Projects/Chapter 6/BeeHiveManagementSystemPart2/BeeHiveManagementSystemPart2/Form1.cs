using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagementSystemPart2
{
    public partial class Form1 : Form
    {
        int numberOfShiftsToWork;
        string jobToAssign;
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
            "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol"}, 155);
            queen = new Queen(workers, 275);

        }

        private void Shifts_ValueChanged(object sender, EventArgs e)
        {
            numberOfShiftsToWork = (int)shifts.Value;
        }

        private void AssignJobsButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(jobToAssign, numberOfShiftsToWork) == false)
            {
                MessageBox.Show("No workers are available to do the job '" +
                    workerBeeJob.Text + "'", "The queen bee says...");
            }
            else
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "
                    + shifts.Value + " shifts", "The queen bee says...");
        }

        private void WorkNextShiftButton_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void WorkerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: May have to update this as selected item returns an object
            jobToAssign = workerBeeJob.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage = 0;
        int endingMileage = 0;
        double milesTraveled = 0;
        double reimbursementRate = 0.39;
        double amountOwed = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (InitialMileage.Value < FinalMileage.Value)
            {
                startingMileage = (int)InitialMileage.Value;
                endingMileage = (int)FinalMileage.Value;

                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimbursementRate;

                label4.Text = "$" + amountOwed;

            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.", 
                    "Cannot Calculate Mileage");
            }
        }
    }
}

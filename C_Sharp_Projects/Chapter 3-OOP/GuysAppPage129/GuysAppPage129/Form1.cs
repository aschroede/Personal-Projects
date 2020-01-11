using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GuysAppPage129
{
    public partial class Form1 : Form
    {
        
        int bankAmount = 100;
        Guy joe;
        Guy bob;
        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "joe" };
            bob = new Guy() { Cash = 100, Name = "bob" };
            UpdateForm();
            
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            banksCashLabel.Text = "The bank has $" + bankAmount;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bankAmount >= 10)
            {
                bankAmount -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bankAmount += bob.GiveCash(5);
            UpdateForm();
        }

        private void JoeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();
            }
            else
                MessageBox.Show("Joe does not have $10 to give bob.");
        }

        private void BobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();
            }
            else
                MessageBox.Show("Bob does not have $5 to give Joe.");
        }

        private void saveJoe_Click(object sender, EventArgs e)
        {
            using(Stream output = File.Create("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void loadJoe_Click(object sender, EventArgs e)
        {
            using(Stream input = File.OpenRead("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}

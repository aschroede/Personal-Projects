using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExcercisePage717
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just clicked on the form");
        }

        private void SaySomethingImGivinUpOnYou(object sender, EventArgs e)
        {
            MessageBox.Show("Say something I'm giving up on you");
        }

        private void SaySomethingElse(object sender, EventArgs e)
        {
            MessageBox.Show("Something else");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(SaySomethingElse);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(SaySomethingImGivinUpOnYou);
        }
    }
}

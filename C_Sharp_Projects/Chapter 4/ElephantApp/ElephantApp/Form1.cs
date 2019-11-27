using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantApp
{
    public partial class Form1 : Form
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            Elephant lucindaBackup = lucinda;
            lucinda = lloyd;
            lloyd = lucindaBackup;

            MessageBox.Show("Objects Swapped");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}

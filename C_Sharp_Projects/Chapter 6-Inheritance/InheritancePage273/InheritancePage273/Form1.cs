using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritancePage273
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyBaseClass baseClass = new MyBaseClass("I'm the base class!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySubClass subClass = new MySubClass("I'm the base class!", 42);
        }
    }
}

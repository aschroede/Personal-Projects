using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsolidateAConditionalExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 5;
            string text = "Hi there";
            if (NewMethod(value, text))
                MessageBox.Show("Pow!");
        }

        private static bool NewMethod(int value, string text)
        {
            return value == 36 || text.Contains("there");
        }
    }
}

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

namespace UnicodeExcercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eureka_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.WriteLine("{0} ", b);
            }
            Console.WriteLine();
        }

        private void hexEureka_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.WriteLine("{0:x2} ", b);
            }
            Console.WriteLine();
        }

        private void hebrew_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
            {
                Console.WriteLine("{0:x2} ", b);
            }
            Console.WriteLine();
        }
    }
}

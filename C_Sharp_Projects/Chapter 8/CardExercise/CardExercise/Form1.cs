using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardExercise
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);

            Card card = new Card((Suit)numberBetween0and3, (Value)numberBetween1and13);

            label1.Text = card.Name;
        }
    }
}

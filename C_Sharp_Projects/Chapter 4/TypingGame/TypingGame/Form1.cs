using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        Stats stats = new Stats();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Add a random key to the LIstBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count>7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user pressed a key that's in the ListBox, remove it
            // and then make the game a little faster
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                // The user pressed a correct key, so update that Stats object
                // by call int its Update() method with the argument true
                stats.Update(true);
               
            }

            else if (e.KeyCode == Keys.Enter)
            {
                stats.Correct = 0;
                stats.Missed = 0;
                stats.Total = 0;
                stats.Accuracy = 0;
                timer1.Interval = 800;
                difficultyProgressBar.Value = 0;

                listBox1.Items.Clear();
                listBox1.Items.Add("Starting new game");
                listBox1.Refresh();
                Thread.Sleep(3000);
                listBox1.Items.Clear();
                listBox1.Refresh();
                timer1.Start();
            }

            else
            {
                // The user pressed an incorrect key, so update the Stats object
                // by calling its Update() method with the argumetn false
                stats.Update(false);
            }

            // Update the labels on the StatusStrip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}

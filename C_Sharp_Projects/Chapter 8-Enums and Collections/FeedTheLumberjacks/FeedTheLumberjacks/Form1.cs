using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedTheLumberjacks
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine;
        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
        }

        private void AddFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawList();
        }

        private void AddLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            RedrawList();
        }

        private void NextLumberjack_Click(object sender, EventArgs e)
        {

            Lumberjack currentLumberjack = breakfastLine.Dequeue();
            currentLumberjack.EatFlapjacks();
            RedrawList();
        }

        private void RedrawList()
        {
            int numberInLine = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(numberInLine + ". " + lumberjack.Name + "\n");
                ++numberInLine;
            }
            

            if(breakfastLine.Count > 0)
            {
                Lumberjack currentLumberjack = breakfastLine.Peek();
                lumberJackSummary.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";
            }

            Refresh();
        }
    }
}

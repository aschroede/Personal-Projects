using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    /// <summary>
    /// Main class for the ADayAtTheRaces game. This class instantiates all the GreyHound and Guy instances
    /// and provides the logic to interact with the GUI. 
    /// </summary>
    public partial class Form1 : Form
    {
        int MaximumBet = 15;  // TODO: Why is this 16? The maximum bet is 15.
        Random randomizer = new Random();
        int startingPosition = 0;

        GreyHound[] GreyHoundArray = new GreyHound[4]; // Create a new 4 position GreyHound array.
        Guy[] GuysArray = new Guy[3]; // Create a new 3 position Guys array. 

        public Form1()
        {
            InitializeComponent();

            // Initialize Greyhounds
            for (int i = 0; i < 4; i++)
            {
                int val = i + 1;
                PictureBox doglabel = (PictureBox)this.Controls["dog" + val.ToString()]; // Create a new dog label so iteration is possible (dog1, dog2, etc)
                GreyHoundArray[i] = new GreyHound(doglabel, startingPosition, Racetrack.Width, randomizer, "Dog " + val);
            }

            // Initialize Guys       
            GuysArray[0] = new Guy() { Name = "Joe", Cash = 50, MyLabel = JoeLabel, MyRadioButton = JoeRadioButton, MyBet = null };
            GuysArray[1] = new Guy() { Name = "Bob", Cash = 75, MyLabel = BobLabel, MyRadioButton = BobRadioButton, MyBet = null };
            GuysArray[2] = new Guy() { Name = "Al", Cash = 45, MyLabel = AlLabel, MyRadioButton = AlRadioButton, MyBet = null };

            // Update labels
            foreach (Guy guy in GuysArray)
            {
                guy.UpdateLabels();
            }
        }

        #region Methods
        /// <summary>
        /// Method to start a new race when the Race! button is clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            if (GuysArray[0].MyBet != null && GuysArray[1].MyBet != null && GuysArray[2].MyBet != null) // All guys must place a bet.
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Joe, Bob, and Al must all place bets before a race can start!");
            }
        }

        /// <summary>
        /// A method that gets called every time the timer interval elapses. This causes the dogs to race
        /// and will reset the race parameters after a dog has won. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyHoundArray.Length; i++) // 1... For each dog
            {
                BettingParlorMenu.Enabled = false; // No actions can occur while a race is underway.

                if (GreyHoundArray[i].Run()) // 1... make it race. If the dog has won, it will return true. 
                {
                    ResetRace(i);
                    break;
                }
            }
        }

        /// <summary>
        /// Resets the race.
        /// </summary>
        /// <param name="i"> Number of dog that won the game. </param>
        private void ResetRace(int i)
        {
            timer1.Stop(); // The race is over. 
            MessageBox.Show(GreyHoundArray[i].Name + " has won the race!");

            foreach (Guy guy in GuysArray) // Collect payouts from bets, clear bets, and update labels
            {
                guy.Collect(i + 1);
                guy.ClearBet();
                guy.UpdateLabels();
            }

            // Reset bet labels
            JoeLabel.Text = GuysArray[0].Name + " hasn't placed a bet";
            BobLabel.Text = GuysArray[1].Name + " hasn't placed a bet";
            AlLabel.Text = GuysArray[2].Name + " hasn't placed a bet";

            foreach (GreyHound greyHound in GreyHoundArray)
            {
                greyHound.TakeStartingPosition(); // reset GreyHounds
            }

            MaximumBet = 15;  // Reset maximum bet to 15
            MinimumBetLabel.Text = "Minimum Bet: "; // Clear the minimum bet label.
            BettingParlorMenu.Enabled = true;  // Enable the betting parlor
        }


        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Joe";
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Bob";
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Al";
        }

        private void GuyPlacesBet(int Guy)
        {
            GuysArray[Guy].PlaceBet((int)numericUpDown1.Value, (int)NumericUpDownDogNumber.Value);
            GuysArray[Guy].UpdateLabels();
            if ((int)numericUpDown1.Value <= MaximumBet)
            {
                MinimumBetLabel.Text = "Minimum Bet: " + (int)numericUpDown1.Value;
                MaximumBet = (int)numericUpDown1.Value;
            }
        }
        private void BetsButton_Click(object sender, EventArgs e)
        {
            switch (NameLabel.Text)
            {
                case "Joe":
                    if (GuysArray[0].Cash >= (int)numericUpDown1.Value)
                    {
                        GuyPlacesBet(0);
                    }
                    else
                    {
                        MessageBox.Show("Joe does not have enough money to place that bet!");
                    }

                    break;

                case "Bob":
                    if (GuysArray[1].Cash >= (int)numericUpDown1.Value)
                    {
                        GuyPlacesBet(1);
                    }
                    else
                    {
                        MessageBox.Show("Bob does not have enough money to place that bet!");
                    }

                    break;

                case "Al":
                    if (GuysArray[2].Cash >= (int)numericUpDown1.Value)
                    {
                        GuyPlacesBet(2);
                    }
                    else
                    {
                        MessageBox.Show("Al does not have enough money to place that bet!");
                    }

                    break;

                default:

                    break;
            }
        }
        #endregion
    }
}

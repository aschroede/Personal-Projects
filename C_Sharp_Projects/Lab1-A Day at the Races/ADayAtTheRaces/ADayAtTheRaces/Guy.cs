using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    /// <summary>
    /// The Guy class defines a data object that is used for creating new instances of the Guy object. 
    /// This class contains several methods that allow the Guy instance to place a bet, clear a bet, 
    /// collect money from bet, and update their labels on the form.
    /// </summary>
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;


        /// <summary>
        /// Method for updating each Guy's radio button with his name and amount of cash. 
        /// Also updates the Guy's bet description, if he has placed a bet and MyBet is not null.
        /// </summary>
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();  //MyBet.GetDescription() returns a string with the bet description.
            }
        }

        /// <summary>
        /// Sets the amount of the Guy's bet to 0. 
        /// </summary>
        public void ClearBet()
        {
            MyBet = null;
        }

        /// <summary>
        /// Allows a Guy instance to place a new bet.
        /// </summary>
        /// <param name="BetAmount"> Amount to bet </param>
        /// <param name="DogToWin"> Dog to place bet on </param>
        /// <returns> Returns a boolean value. True if bet was placed, false if not enough money. </returns>
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet();
            if (Cash >= 5)  // Minimum allowed bet is $5
            {
                MyBet.Bettor = this;
                MyBet.Amount = BetAmount;
                MyBet.Dog = DogToWin;
                return true;
            }
            else
            {
                return false;
            }           
        }

        /// <summary>
        /// Method to collect the payout of a bet placed.
        /// </summary>
        /// <param name="Winner"> The dog that won the race. </param>
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet(); // After a payout, make sure to clear the bet...
            UpdateLabels(); // and update the labels.
        }
    }
}

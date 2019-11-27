using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    /// <summary>
    /// The bet class allows an instance of the Guy class to place a bet and has methods
    /// to get the description of the bet and to payout the bet.
    /// </summary>
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor; 

        /// <summary>
        /// Method that returns a string used to update the bet labels on the form.
        /// </summary>
        /// <returns> Returns a string with the bet description. </returns>
        public string GetDescription()
        {          
            return Bettor.Name + " bets "+ Amount + " bucks on dog #" + Dog;
        }

        /// <summary>
        /// Method to payout the bet.
        /// </summary>
        /// <param name="Winner"> The dog that won. </param>
        /// <returns> Either the positive amount of the bet if the winning dog 
        /// is the same as the dog betted on or the negative amount if the winning
        /// dog is not the same dog the bet was placed on. </returns>
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}

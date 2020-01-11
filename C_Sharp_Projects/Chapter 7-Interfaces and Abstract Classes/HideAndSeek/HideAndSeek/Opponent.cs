using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Tracing;
using Serilog;

namespace HideAndSeek
{
    class Opponent
    {
        public Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        /// <summary>
        /// Method to randomly move the opponent when a new game begins.
        /// </summary>
        public void Move()
        {
            do
            {
                if (myLocation is IHasExteriorDoor)
                {
                    if (random.Next(2) == 1)
                        myLocation = (myLocation as IHasExteriorDoor).DoorLocation;
                }
                int exit = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[exit];
            } while (!(myLocation is IHidingPlace));

            Log.Information("Opponent's current location: {0}", (myLocation.Name));
        }

        /// <summary>
        /// Method that checks if the opponent is hiding in the room's hiding place
        /// </summary>
        /// <param name="hidingLocation">Hiding place to check</param>
        /// <returns>Returns true if the opponent is hiding in the hiding place
        /// and returns false otherwise</returns>
        public bool Check(Location hidingLocation)
        {
            if ((myLocation as IHidingPlace).HidingPlace == (hidingLocation as IHidingPlace).HidingPlace)
                return true;
            else
                return false;
        }
    }
}
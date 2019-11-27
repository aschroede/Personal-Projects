using System;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    /// <summary>
    /// The GreyHound class can be used to instantiate new instances of GreyHound which can compete in the race.
    /// This class defines a constructor to initialize the GreyHound, and methods for racing the dog as well as 
    /// resetting the position of the GreyHound instance.
    /// </summary>
    class GreyHound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;
        public string Name; 

        // Constructor
        public GreyHound(PictureBox pictureBox, int startingPosition, int racetrackLength, Random randomizer, string name)
        {
            MyPictureBox = pictureBox;
            StartingPosition = startingPosition;
            RacetrackLength = racetrackLength;
            Randomizer = randomizer;
            Name = name;
        }

        #region Methods
        /// <summary>
        /// Method to start racing a dog.
        /// </summary>
        /// <returns> A boolean value. True if the dog has won the race, otherwise false. </returns>
        public bool Run()
        {
            Location = Randomizer.Next(1, 4);
            MyPictureBox.Left = StartingPosition + Location;
            StartingPosition = MyPictureBox.Left;

            // Return true if the right portion of the dog image touches the right edge of the track
            if (MyPictureBox.Left >= RacetrackLength - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        /// <summary>
        /// Resets the greyhound's position after a race. 
        /// </summary>
        public void TakeStartingPosition()
        {
            MyPictureBox.Left = 0;
            Location = 0;
            StartingPosition = 0;
        }

        #endregion
    }

}

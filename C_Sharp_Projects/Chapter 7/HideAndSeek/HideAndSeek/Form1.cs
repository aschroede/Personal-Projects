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
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace HideAndSeek
{
    /// <summary>
    /// The main form the user interacts with to play the game
    /// </summary>
    public partial class Form1 : Form
    {
        Location currentLocation;
        Opponent opponent;
        OutsideWithDoor frontYard;
        RoomWithDoor livingRoom;
        int NumberOfMoves;
        public Form1()
        {

            InitializeComponent();
            CreateObjects();
        }
        
        /// <summary>
        /// Initializes all the room objects, sets their exits, and initializes the form.
        /// </summary>
        public void CreateObjects()
        {

            Log.Information("Creating objects now...");

            // Create rooms
            livingRoom = new RoomWithDoor("livingroom", "an antique carpet", "an oak door with a brass knob.", "living room closet");
            Room diningRoom = new Room("dining room", "a crystal chandelier");
            RoomWithDoor kitchen = new RoomWithDoor("kitchen", "stainless steel appliances", "a screen door.", "cabinet");
            OutsideWithDoor backYard = new OutsideWithDoor("backyard", false, "a screen door");
            frontYard = new OutsideWithDoor("frontyard", true, "an oak door with a brass knob");
            OutsideWithHidingPlace garden = new OutsideWithHidingPlace("Garden", false, "shed");
            Room stairs = new Room("stairs", "a wooden bannister");
            RoomWithHidingPlace upstairsHallway = new RoomWithHidingPlace("upstairs hallway", "a picture of a dog", "hallway closet");
            RoomWithHidingPlace masterBedroom = new RoomWithHidingPlace("master bedroom", "a large bed", "large bed");
            RoomWithHidingPlace secondBedroom = new RoomWithHidingPlace("second bedroom", "a small bed", "small bed");
            RoomWithHidingPlace bathroom = new RoomWithHidingPlace("bathroom", " a sink and a toilet", "shower");
            OutsideWithHidingPlace driveway = new OutsideWithHidingPlace("driveway", true, "garage");

            // Set the locations on the other side of doors
            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;

            // Set the exits associated with each room
            driveway.Exits = new Location[] { frontYard, backYard };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };
            upstairsHallway.Exits = new Location[] { stairs, masterBedroom, secondBedroom, bathroom };
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            livingRoom.Exits = new Location[] { diningRoom, stairs};
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };

            // Set the opponents starting position 
            opponent = new Opponent(frontYard);

            // Make sure only the Hide! control is visible at the beginning of the game
            check.Visible = false;
            goHere.Visible = false;
            exits.Visible = false;
            goThroughTheDoor.Visible = false;
            hide.Visible = true;
            LoadNewPict("hideandseek");
        }

        /// <summary>
        /// Method for user to move to a new location
        /// </summary>
        /// <param name="location"> Location to move to </param>
        void MoveToANewLocation(Location location)
        {
            currentLocation = location;

            // Updates image in form to show room currently occupied
            LoadNewPict(location.Name);

            // Clear the exits dropdown options and populate with new exits
            exits.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                string s = exit.Name;
                s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s);
                exits.Items.Add(s);
            }

            // Make the exits dropdown select the first item in its list
            exits.SelectedIndex = 0;

            // Populate the description box with description of current room
            description.Text = currentLocation.Description;

            // If this room has a door, display the "Go through door" button
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;

            // If this room has a hiding place, display the "Check" button with the 
            // name of the hiding place after it. 
            if(currentLocation is IHidingPlace)
            {
                check.Visible = true;

                string checkstring = "Check ";
                switch ((currentLocation as IHidingPlace).HidingPlace)
                {
                    case "shower":
                        check.Text = checkstring + "in the shower";
                        break;
                    case "living room closet":
                        check.Text = checkstring + "in the closet";
                        break;
                    case "cabinet":
                        check.Text = checkstring + "in the cabinet";
                        break;
                    case "shed":
                        check.Text = checkstring + "in the shed";
                        break;
                    case "hallway closet":
                        check.Text = checkstring + "in the closet";
                        break;
                    case "large bed":
                        check.Text = checkstring + "under the bed";
                        break;
                    case "small bed":
                        check.Text = checkstring + "under the bed";
                        break;
                    case "garage":
                        check.Text = checkstring + "in the garage";
                        break;
                }      
            }
            else
                check.Visible = false;

            // Increment the number of moves tally
            ++NumberOfMoves;

            Log.Information("Your current location: {0}", currentLocation.Name);
        }


        /// <summary>
        /// Method to reset the game to its initial state
        /// </summary>
        private void ResetGame()
        {
            Log.Information("Resetting the game...");

            description.Text = "You found your opponent in the " + 
                (opponent.myLocation as IHidingPlace).HidingPlace + " in " + NumberOfMoves + " moves.";
            opponent = new Opponent(frontYard);

            check.Visible = false;
            goHere.Visible = false;
            exits.Visible = false;
            goThroughTheDoor.Visible = false;
            hide.Visible = true;
            
        }

        /// <summary>
        /// Method for loading pictures into the picturebox.
        /// </summary>
        /// <param name="name">Name of the image file without the .jpg extension</param>
        private void LoadNewPict(string name)
        {
            string picturePath = null;
            try
            {
                picturePath = System.IO.Directory.GetCurrentDirectory() + @"\Images\" + name + ".jpg";
                pictureBox1.Image = Image.FromFile(picturePath);
                Log.Information("Loading {0}...", picturePath);
            }
            catch (Exception ex)
            {

                Log.Error(ex, "Failed to load {0}", picturePath);
            }

        }

        /// <summary>
        /// Event handler for the "Hide!" button which causes the opponent
        /// to hide in a room with a hiding place. Also counts to 10 before
        /// game begins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hide_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                description.Text = i.ToString() + "...";
                opponent.Move();
                Thread.Sleep(300);
                Refresh();
            }
            Thread.Sleep(300);
            RedrawForm();
        }

        /// <summary>
        /// Method to redraw the form and display the appropriate controls
        /// at the beginning of a new game. 
        /// </summary>
        private void RedrawForm()
        {
            Log.Information("Redrawing form...");
            description.Text = "Ready or not, here I come!";
            Refresh();
            Thread.Sleep(2000);

            goHere.Visible = true;
            exits.Visible = true;
            goThroughTheDoor.Visible = true;
            hide.Visible = false;
            description.Clear();

            // The user always begins in the living room
            MoveToANewLocation(livingRoom);
        }

        /// <summary>
        /// Causes the player to move to the selected location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
            Log.Information("You have moved to a new location: {0}", currentLocation.Name);
        }

        /// <summary>
        /// Causes the player to go through door
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor currentLocationVariable = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(currentLocationVariable.DoorLocation);
            Log.Information("You have moved to a new location: {0}", currentLocation.Name);
        }

        /// <summary>
        /// Event handler for when the user selects "Check". Checks to see
        /// if the opponent is hiding in the current location. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_Click(object sender, EventArgs e)
        {
            if (opponent.Check(currentLocation))
            {
                if (NumberOfMoves > 1)
                    MessageBox.Show("You found me in " + NumberOfMoves + " moves!");
                else
                    MessageBox.Show("You found me in " + NumberOfMoves + " move!");
                ResetGame();

                Log.Information("You found the opponent in {0} moves", NumberOfMoves);
            }

            else
            {
                check.Text = "Hmm... not here!";
            }

            // Increment the number of moves tally
            ++NumberOfMoves;
        }
    }
}

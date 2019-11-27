using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseBuilder
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }

        public void CreateObjects()
        {
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room","an antique carpet", "an oak door with a brass knob.");
            Room diningRoom = new Room("Dining Room", "a crystal chandelier");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door.");
            OutsideWithDoor backYard = new OutsideWithDoor("Backyard", false, "a screen door");
            OutsideWithDoor frontYard = new OutsideWithDoor("Frontyard", true, "an oak door with a brass knob");
            Outside garden = new Outside("Garden", false);

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;


            livingRoom.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom };
            backYard.Exits = new Location[] { frontYard, garden};
            frontYard.Exits = new Location[] { backYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            MoveToANewLocation(livingRoom);
        }

        void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            exits.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                exits.Items.Add(exit.Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }
        private void GoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void GoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor currentLocationVariable = currentLocation as IHasExteriorDoor;

            MoveToANewLocation(currentLocationVariable.DoorLocation);
        }
    }
}

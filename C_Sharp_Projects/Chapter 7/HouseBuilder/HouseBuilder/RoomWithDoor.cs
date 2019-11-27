using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public RoomWithDoor(string name, string decoration, string doorDescription) : base (name, decoration)
        {
            DoorDescription = doorDescription;
        }
        
    }
}

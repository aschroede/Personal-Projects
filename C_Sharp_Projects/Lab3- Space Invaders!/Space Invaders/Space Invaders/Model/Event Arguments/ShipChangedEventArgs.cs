using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Space_Invaders.Model.Event_Arguments
{
    class ShipChangedEventArgs : EventArgs
    {
        public Ship ShipUdated { get; private set; }
        public bool Killed { get; private set; }

        public ShipChangedEventArgs(Ship shipUpdated, bool killed)
        {
            ShipUdated = shipUpdated;
            Killed = killed;
        }
    }
}

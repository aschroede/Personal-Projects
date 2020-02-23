using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Model.Event_Arguments
{
    class ShotMovedEventArgs : EventArgs
    {
        public Shot Shot { get; private set; }
        public bool Disappeared { get; private set; }
        public bool PlayerShot { get; private set; }

        public ShotMovedEventArgs(Shot shot, bool disappeared, bool playerShot)
        {
            Shot = shot;
            Disappeared = disappeared;
            PlayerShot = playerShot;
        }
    }
}

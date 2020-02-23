using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Space_Invaders.Model.Event_Arguments
{
    class StarChangedEventArgs : EventArgs
    {
        public Point Point { get; private set; }
        public bool Disappeared { get; private set; }

        public StarChangedEventArgs(Point point, bool disappeared)
        {
            Point = point;
            Disappeared = disappeared;
        }
    }
}

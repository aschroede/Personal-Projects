using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Space_Invaders.Model
{
    class Player : Ship
    {
        public readonly Size PlayerSize = new Size(25, 15);
        private const double Speed = 5;

        public Player(Point location, Size size) : base(location, size)
        {
            // Do nothing?
        }
        
        public override void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    if (Location.X <= 0)
                        return;
                    Location = new Point(Location.X - Speed, Location.Y);
                    break;
                case Direction.Right:
                    if (Location.X >= InvadersModel.PlayAreaSize.Width-PlayerSize.Width)
                        return;
                    Location = new Point(Location.X + Speed, Location.Y);
                    break;
            }
        }
    }
}

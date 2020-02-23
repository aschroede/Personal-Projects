using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Space_Invaders.Model
{
    class Invader : Ship
    {
        public static Size InvaderSize { get; private set; }
        public InvaderType InvaderType { get; private set; }
        public int Score { get; private set; }

        public Invader(InvaderType invaderType, Point location, Size size, int score) : base(location, size)
        {
            InvaderType = invaderType;
            InvaderSize = size;
            Score = score;
        }

        public override void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    Location = new Point(Location.X - 7, Location.Y);
                    break;
                case Direction.Right:
                    Location = new Point(Location.X + 7, Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + 10);
                    break;
            }
        }
    }
}

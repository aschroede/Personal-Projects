using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Mover {

        private const int MoveInterval = 15; 

        protected Point location;
        public Point Location { get { return location; } }
        protected Game game; 

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }


        public bool Nearby(Point locationToCheck, int distance)
        {
            return ComparePoints(locationToCheck, null, distance);
        }

        public bool Nearby(Point locationToCheck1, Point locationToCheck2, int distance)
        {
            return ComparePoints(locationToCheck1, locationToCheck2, distance);
        }

        private bool ComparePoints(Point locationToCheck1, Point? locationToCheck2, int distance)
        {
            Point target;
            if (locationToCheck2.HasValue)
                target = locationToCheck2.Value;
            else
                target = location;
            if (Math.Abs(target.X - locationToCheck1.X) < distance &&
                (Math.Abs(target.Y - locationToCheck1.Y) < distance))
                return true;
            else
                return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            return MoveMethod(direction, null, boundaries, null);
        }
        public Point Move(Direction direction, Point target, Rectangle boundaries, int? moveInterval)
        {
            return MoveMethod(direction, target, boundaries, moveInterval);
        }

        private Point MoveMethod(Direction direction, Point? target, Rectangle boundaries, int? moveInterval)
        {

            Point newLocation = location;
            Point temporary;
            int temporaryMoveInterval;

            if (moveInterval.HasValue)
                temporaryMoveInterval = moveInterval.Value;
            else
                temporaryMoveInterval = MoveInterval;

            if (target.HasValue)
                temporary = target.Value;
            else
                temporary = newLocation;

            switch (direction)
            {
                case Direction.Up:
                    if (temporary.Y - temporaryMoveInterval >= boundaries.Top)
                        temporary.Y -= temporaryMoveInterval;
                    break;
                case Direction.Down:
                    if (temporary.Y + temporaryMoveInterval <= boundaries.Bottom)
                        temporary.Y += temporaryMoveInterval;
                    break;
                case Direction.Left:
                    if (temporary.X - temporaryMoveInterval >= boundaries.Left)
                        temporary.X -= temporaryMoveInterval;
                    break;
                case Direction.Right:
                    if (temporary.X + temporaryMoveInterval <= boundaries.Right)
                        temporary.X += temporaryMoveInterval;
                    break;
                default:
                    break;

            }
            return temporary;
        }
    }
}

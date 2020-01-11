using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(3) == 0)
                {
                    Direction direction = FindPlayerDirection(game.PlayerLocation);
                    location = Move(direction, game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(4, random);
                }
                else
                {
                    Direction randomDirection = (Direction)random.Next(4);
                    location = Move(randomDirection, game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(4, random);
                }
            }
        }
    }
}


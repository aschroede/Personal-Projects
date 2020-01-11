using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random)
        {
            if(HitPoints >= 1)
            {
                if (random.Next(2) == 1)
                {
                    Direction direction = FindPlayerDirection(game.PlayerLocation);
                    location = Move(direction, game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(3, random);
                }
                else
                {
                    Direction randomDirection = (Direction)random.Next(4);
                    location = Move(randomDirection, game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(3, random);
                }
            }
        }
    }
}

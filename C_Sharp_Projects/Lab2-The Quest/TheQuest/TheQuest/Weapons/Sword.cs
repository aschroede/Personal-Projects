using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location):base(game, location) { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            if(!DamageEnemy(direction, 30, 3, random))
            {
                int originalDirectionNumber = (int)direction;
                int clockwiseDirection;

                if (originalDirectionNumber == 3)
                    clockwiseDirection = 0;
                else
                    clockwiseDirection = originalDirectionNumber + 1;

                if(!DamageEnemy((Direction)(clockwiseDirection), 30, 3, random))
                {
                    int counterClockWiseDirection;

                    if (originalDirectionNumber == 0)
                        counterClockWiseDirection = 3;
                    else
                        counterClockWiseDirection = originalDirectionNumber - 1;
                    DamageEnemy((Direction)(counterClockWiseDirection), 30, 3, random);
                }
            }
        }
    }
}

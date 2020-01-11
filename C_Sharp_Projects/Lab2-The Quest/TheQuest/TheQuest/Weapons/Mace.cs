using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            if(!DamageEnemy(Direction.Up, 30, 6, random))
                if(!DamageEnemy(Direction.Right, 30, 6, random))
                    if(!DamageEnemy(Direction.Down, 30, 6, random))
                        DamageEnemy(Direction.Left, 30, 6, random);
        }
    }
}

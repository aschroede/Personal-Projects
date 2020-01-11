using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() 
        { 
            PickedUp = true; 
        }

        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);
        
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    Console.WriteLine("Enemy Location: {0}\n" +
                    "Target Location: {1}\n" +
                    "Distance: {2}\n" +
                    "Radius: {3}\n" +
                    "--------------", enemy.Location, target, distance, radius);

                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);

                        return true;

                    }
                }
                target = Move(direction, target, game.Boundaries, 1); //TODO: Figure out why this statement is here.

            }

            //Point target = game.PlayerLocation;
            //foreach (Enemy enemy in game.Enemies)
            //{
            //    Console.WriteLine("Enemy Location: {0}\n" +
            //    "Target Location: {1}\n" +
            //    "Radius: {2}\n" +
            //    "--------------", enemy.Location, target, radius);

            //    if (Nearby(enemy.Location, target, radius))
            //    {
            //        enemy.Hit(damage, random);

            //        return true;

            //    }
            //}
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedTheLumberjacks
{
    class Lumberjack : Ic
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine(Name + "'s eating flapjacks\n");

            foreach(Flapjack flapjack in meal)
            {
                Console.WriteLine(Name + " ate a " + flapjack.ToString().ToLower() + " flapjack\n"); ; ;
            }
        }
    }

    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }
}

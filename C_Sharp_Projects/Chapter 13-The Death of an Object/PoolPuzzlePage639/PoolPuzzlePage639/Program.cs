using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzlePage639
{
    class Program
    {
        static void Main(string[] args)
        {
            Faucet newFaucet = new Faucet();
            Console.ReadKey();
        }

        public class Faucet
        {
            public Faucet()
            {
                Table wine = new Table();
                Hinge book = new Hinge();
                wine.Set(book);
                book.Set(wine);
                wine.Lamp(10);
                book.garden.Lamp("back in");
                book.bulb *= 2;
                wine.Lamp("minutes");
                wine.Lamp(book);
            }
        }

        public struct Table
        {
            public string stairs;
            public Hinge floor;
            public void Set(Hinge b)
            {
                floor = b;
            }

            public void Lamp(object oil) //Boxing happens here!
            {
                if (oil is int)
                {
                    floor.bulb = (int)oil;
                }
                else if (oil is string)
                {
                    stairs = (string)oil;
                }
                else if (oil is Hinge)
                {
                    Hinge vine = oil as Hinge;
                    Console.WriteLine(vine.Table()
                        + " " + floor.bulb + " " + stairs);
                }
            }
        }

        // minutes 20 minutes

        public class Hinge
        {
            public int bulb;
            public Table garden;
            public void Set(Table a)
            {
                garden = a;
            }
            public string Table()
            {
                return garden.stairs;
            }
        }
    }
}

System.Collections.Generic.IEnumerable<int>;
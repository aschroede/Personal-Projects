using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThisPage363
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, color = "Brown" });
            shoeCloset.Add(new Shoe() { Style = Style.Wingtips, color = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, color = "White" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, color = "Red" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, color = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.color = "Orange";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if(shoeCloset.Contains(secondShoe))
                Console.WriteLine("That's surprising.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamePage375
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                Console.WriteLine(cards[i].Name);
            }

            Console.WriteLine("\n And here are the cards sorted:\n");
            CardComparer_byValue cardComparer = new CardComparer_byValue();
            cards.Sort(cardComparer);

            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExercisePage381
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suit.Clubs, Value.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suit.Hearts);
            Console.WriteLine(doesItMatch);
            Console.ReadKey();
        }
    }
}

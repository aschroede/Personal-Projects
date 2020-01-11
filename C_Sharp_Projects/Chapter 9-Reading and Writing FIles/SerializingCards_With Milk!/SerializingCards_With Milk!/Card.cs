using System;
using System.Collections.Generic;
using System.Text;

namespace SerializingCards_With_Milk_
{
    [Serializable]
    class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
        public string Name {
            get
            {
                return Value + " of " + Suit;
            } 
        }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }

        public static string Plural(Value value)
        {
            if (value == Value.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CardExercise
{
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
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        public string Name {
            get
            {
                return Value + " of " + Suit;
            } 
        }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
    }
}

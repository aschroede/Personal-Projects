using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuySerializer
{
    [DataContract(Namespace = "blabla")]
    class Card
    {
        [DataMember]
        public Suit Suit { get; set; }

        [DataMember]
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        private static Random r = new Random();

        public static Card RandomCard()
        {
            return new Card((Suit)r.Next(4), (Value)r.Next(1, 14));
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

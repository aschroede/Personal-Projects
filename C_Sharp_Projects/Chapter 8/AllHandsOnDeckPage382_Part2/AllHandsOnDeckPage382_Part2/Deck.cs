using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AllHandsOnDeckPage382_Part2
{
    class Deck
    {
        public List<Card> cards;
        private Random random = new Random();
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suit)suit, (Value)value));
                }
            }
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        public int Count { get { return cards.Count; } }
        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        public Card Deal()
        {
            return Deal(0);
        }
        public void Shuffle()
        {
            List<Card> temporary = new List<Card>(cards);
            cards.Clear();
            int i = 0;
            while (temporary.Count != 0)
            {
                int index = random.Next(0, temporary.Count);
                cards.Add(temporary[index]);
                temporary.RemoveAt(index);
                ++i;
            }
        }
        public IEnumerable<string> GetCardNames()
        {
            string[] cardArray = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                cardArray[i] = cards[i].Name;
            }
            return cardArray;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}

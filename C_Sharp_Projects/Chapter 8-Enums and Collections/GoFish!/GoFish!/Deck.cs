﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish_
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

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public bool ContainsValue(Value value)
        {
            foreach (Card card in cards)
            {
                if (card.Value == value)
                    return true;
            }
            return false;
        }

        public Deck PullOutValues(Value value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            }
            return deckToReturn;
        }

        public bool HasBook(Value value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
            {
                if (card.Value == value)
                    NumberOfCards++;
            }
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }

    }
}

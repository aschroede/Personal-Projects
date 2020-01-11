using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllHandsOnDeckPage382_Part2
{
    public partial class Form1 : Form
    {
        private Deck deck1;
        private Deck deck2;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            deck1 = new Deck();
            deck2 = new Deck();
            ResetDeck(1);
            ResetDeck(2);
        }

        public void ResetDeck(int deckToReset)
        {
            if(deckToReset == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card((Suit)random.Next(4),
                        (Value)random.Next(1, 14)));
                }
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
            RedrawDeck(deckToReset);
        }

        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    listBox1.Items.Add(cardName);
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    listBox2.Items.Add(cardName);
                label2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }


        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
                return;
            foreach (string item in listBox1.SelectedItems)
            {
                for (int i = 0; i < deck1.cards.Count; i++)
                {
                    Card sampleCard = deck1.cards[i];
                    if (sampleCard.Name == item)
                    {
                        deck1.cards.Remove(sampleCard);
                        deck2.cards.Add(sampleCard);                      
                    }
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
                return;
            foreach (string item in listBox2.SelectedItems)
            {
                for (int i = 0; i < deck2.cards.Count; i++)
                {
                    Card sampleCard = deck2.cards[i];
                    if (sampleCard.Name == item)
                    {
                        deck2.cards.Remove(sampleCard);
                        deck1.cards.Add(sampleCard);
                    }
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }
    }
}

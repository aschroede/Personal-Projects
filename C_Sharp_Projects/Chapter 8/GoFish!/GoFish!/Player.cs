using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish_
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;     
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

        
        
        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.textBoxOnForm.Text += Name + " has just joined the game" + Environment.NewLine;
            this.cards = new Deck(new Card[] { });
        }

        public IEnumerable<Value> PullOutBooks(Deck stock)
        {

            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;

                if (cards.Count > 0)
                {
                    for (int card = 0; card < cards.Count; card++)
                    {
                        if (cards.Peek(card).Value == value)
                            howMany++;                    
                    }
                    if (howMany == 4)
                    {
                        books.Add(value);
                        cards.PullOutValues(value);
                    }
                    if (cards.Count == 0)
                    {
                        if(stock.Count > 0)
                            cards.Add(stock.Deal());
                    }
                }                  
            }
            return books;

        }

        public Value GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Value value)
        {
            Deck pulledValues = cards.PullOutValues(value);

            if(pulledValues.Count != 0)
                textBoxOnForm.Text += Name + " has " + pulledValues.Count + " " + Card.Plural(value) + Environment.NewLine;
            else
                textBoxOnForm.Text += Name + " has 0 " + Card.Plural(value) + Environment.NewLine;
            return pulledValues;
        }

        public void AskForACard(IEnumerable<Player> players, int myIndex, Deck stock)
        {
            if(cards.Count > 0)
            {
                Value randomValue = GetRandomValue();
                if(randomValue != Value.None)
                {
                    AskForACard(players, myIndex, stock, randomValue);
                }
                
            }
        }

        public void AskForACard(IEnumerable<Player> players, int myIndex, Deck stock, Value value)
        {
            textBoxOnForm.Text += Name + " asks if anyone has a " + value + "." + Environment.NewLine;
            int numberOfCardsAdded = 0;

            List<Player> temporaryList = new List<Player>(players);
            temporaryList.RemoveAt(myIndex);

            foreach (Player player in temporaryList)
            {
                {
                    Deck someCards = player.DoYouHaveAny(value);
                    for (int i = 0; i < someCards.Count; i++)
                    {
                        cards.Add(someCards.Peek(i));
                        ++numberOfCardsAdded;
                    }
                    if (player.cards.Count == 0)
                        if(stock.Count > 0)
                            cards.Add(stock.Deal());
                }              
            }

            if(numberOfCardsAdded == 0)
            {
                if(stock.Count != 0)
                {
                    cards.Add(stock.Deal());
                    textBoxOnForm.Text += Name + " had to draw from the stock." + Environment.NewLine;
                }
                
            }
        }
    }
}

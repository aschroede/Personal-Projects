using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoFish_
{
    internal class Game
    {
        private List<Player> players;
        private Dictionary<Value, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
            {
                players.Add(new Player(player, random, textBoxOnForm));
            }
            books = new Dictionary<Value, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            foreach (Player player in players)
            {
                for (int i = 0; i < 5; i++)
                {
                    player.TakeCard(stock.Deal());
                }
                player.PullOutBooks(stock);
            }
        }
        internal IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribeBooks()
        {
            string longString = "";

            foreach (KeyValuePair<Value, Player> item in books)
            {
                longString += item.Value.Name + " has a book of " + item.Key.ToString() + "." + Environment.NewLine;
            }

            return longString;
        }

        internal string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }

            description += "The stock has " + stock.Count + " cards left." + Environment.NewLine;
            return description;
        }

        internal bool PlayOneRound(int selectedPlayerCard)
        {
            Value cardValue = players[0].Peek(selectedPlayerCard).Value;

            for (int i = 0; i < 3; i++)
            {
                if(i == 0)
                {
                    if (stock.Count == 0)
                    {
                        textBoxOnForm.Text = "The stock is out of cards. Game over! ";
                        return true;
                    }
                    players[i].AskForACard(players, i, stock, cardValue);
                }


                else
                {
                    if (stock.Count == 0)
                    {
                        textBoxOnForm.Text = "The stock is out of cards. Game over! ";
                        return true;
                    }
                    players[i].AskForACard(players, i, stock);
                }
                
                if (PullOutBooks(players[i]))
                {
                    if(stock.Count >= 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (stock.Count == 0)
                            {
                                textBoxOnForm.Text = "The stock is out of cards. Game over! ";
                                return true;
                            }
                            players[i].TakeCard(stock.Deal());                           
                        }
                    }
                    else
                    {
                        int NumberOfCardsLeft = stock.Count;
                        for (int j = 0; j < NumberOfCardsLeft; j++)
                        {
                            if (stock.Count == 0)
                            {
                                textBoxOnForm.Text = "The stock is out of cards. Game over! ";
                                return true;
                            }
                            players[i].TakeCard(stock.Deal());                        
                        }
                    }                    
                }                    
            }

            players[0].SortHand();

            if (stock.Count == 0)
            {
                textBoxOnForm.Text = "The stock is out of cards. Game over! ";
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Value> playerBooks = player.PullOutBooks(stock);
            if(playerBooks != null)
            {
                foreach (Value value in playerBooks)
                {
                    books.Add(value, player);
                }
            }

            if (player.CardCount == 0)
                return true;
            else
                return false;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            int player0Wins = 0;
            int player1Wins = 0;
            int player2Wins = 0;
            int maxBooks = 0;
            List<string> winningNames = new List<string>();

            foreach (Value value in books.Keys)
            {
                if (books[value] == players[0])
                {
                    ++player0Wins;
                    winners.Remove(books[value].Name);
                    winners.Add(books[value].Name, player0Wins);
                }
                else if (books[value] == players[1])
                {
                    ++player1Wins;
                    winners.Remove(books[value].Name);
                    winners.Add(books[value].Name, player1Wins);
                }
                else if (books[value] == players[2])
                {
                    ++player2Wins;
                    winners.Remove(books[value].Name);
                    winners.Add(books[value].Name, player2Wins);
                }             
            }

            foreach (string name in winners.Keys)
            {
                if (winners[name] > maxBooks)
                    maxBooks = winners[name];
            }

            foreach (string name in winners.Keys)
            {
                if(winners[name] == maxBooks)
                {
                    winningNames.Add(name);
                }
            }

            if(winningNames.Count == 1)
            {
                return winningNames[0] + " with " + maxBooks + " books";
            }
            else if(winningNames.Count == 2)
            {
                return "A tie between " + winningNames[0] + " and "
                    + winningNames[1] + " with " + maxBooks + " books";
            }
            else
            {
                return "A tie between " + winningNames[0] + " and "
                    + winningNames[1] +" and " + winningNames[2] 
                    + " with " + maxBooks + " books";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GoFish_WPF
{
    public class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Value, Player> books;
        private Deck stock;

        public event PropertyChangedEventHandler PropertyChanged;


        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }

        public Game()
        {
            PlayerName = "Ed";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bob", random, this));
            players.Add(new Player("Joe", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach (string cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        public void ClearProgress()
        {
            GameProgress = string.Empty;
            OnPropertyChanged("GameProgress");
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

        internal void PlayOneRound(int selectedPlayerCard)
        {
            Value cardValue = players[0].Peek(selectedPlayerCard).Value;

            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardValue);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i]))
                {
                    AddProgress(players[i].Name + " drew a new hand");
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }

                players[0].SortHand();
                OnPropertyChanged("Books");

                if (stock.Count == 0)
                {
                    AddProgress("The stock is out of cards. Game over!");
                    AddProgress("The winner is... " + GetWinnerName());
                    ResetGame();
                    return;
                }
            }

            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands()); // ????
        }

        internal bool PullOutBooks(Player player)
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

        public void AddProgress(string progress)
        {
            GameProgress = progress +
                Environment.NewLine +
                GameProgress;
            OnPropertyChanged("GameProgress");
        }

        public void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Value, Player>();
            stock = new Deck();
            Hand.Clear();
        }

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
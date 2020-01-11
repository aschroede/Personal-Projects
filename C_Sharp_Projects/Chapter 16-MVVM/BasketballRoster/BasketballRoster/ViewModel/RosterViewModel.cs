using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BasketballRoster.Model;

namespace BasketballRoster.ViewModel
{
    class RosterViewModel
    {
        public string TeamName { get; set; }

        public ObservableCollection<PlayerViewModel> Starters { get; set; }
        public ObservableCollection<PlayerViewModel> Bench { get; set; }

        public RosterViewModel(Roster roster)
        {
            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();
            TeamName = roster.TeamName;
            UpdateRosters(roster);
        }

        private void UpdateRosters(Roster roster)
        {
            var benchPlayers =
                from player in roster.Players
                where player.Starter == false
                select player;

            foreach (var player in benchPlayers)
            {
                PlayerViewModel newPlayer = new PlayerViewModel(player.Name, player.Number);
                Bench.Add(newPlayer);
            }

            var starterPlayers =
                from player in roster.Players
                where player.Starter == true
                select player;

            foreach (var player in starterPlayers)
            {
                PlayerViewModel newPlayer = new PlayerViewModel(player.Name, player.Number);
                Starters.Add(newPlayer);
            }
        }
    }
}

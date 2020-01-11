using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketballRoster.Model;

namespace BasketballRoster.ViewModel
{
    class LeagueViewModel
    {
        public RosterViewModel JimmysTeam { get; set; }
        public RosterViewModel BriansTeam { get; set; }

        public LeagueViewModel()
        {
            Roster BriansRoster = new Roster("The Bombers", GetBomberPlayers());
            Roster JimmysRoster = new Roster("The Amazins", GetAmazinPlayers());

            JimmysTeam = new RosterViewModel(JimmysRoster);
            BriansTeam = new RosterViewModel(BriansRoster);
        }

        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>()
            {
                new Player("Brian", 31, true),
                new Player("Lloyd", 23, true),
                new Player("Kathleen", 6, true),
                new Player("Mike", 0, true),
                new Player("Joe", 42, true),
                new Player("Herb", 32, false),
                new Player("Fingers", 8, false),
            };
            return bomberPlayers;
        }

        public IEnumerable<Player> GetAmazinPlayers()
        {
            List<Player> amazinPlayers = new List<Player>()
            {
                new Player("Jimmy", 42, true),
                new Player("Henry", 11, true),
                new Player("Bob", 4, true),
                new Player("Lucinda", 18, true),
                new Player("Kim", 16, true),
                new Player("Bertha", 23, false),
                new Player("Ed", 21, false)
            };
            return amazinPlayers;
        }
    }
}

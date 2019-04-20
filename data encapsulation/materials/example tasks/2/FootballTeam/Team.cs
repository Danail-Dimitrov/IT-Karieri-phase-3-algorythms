using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class Team
    {
        private string name;
        private List<Player> mainTeam;
        private List<Player> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.mainTeam = new List<Player>();
            this.reserveTeam = new List<Player>();
        }

        public string Name { get => name; set => name = value; }

        public IReadOnlyList<Player> MainTeam {
            get => mainTeam;
        }

        public IReadOnlyList<Player> ReserveTeam { get => reserveTeam; }

        public void AddPlayer(Player player)
        {
            if(player.Age < 40)
            {
                this.mainTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }

        public override string ToString()
        {
            return $"First team have {MainTeam.Count} players\nReserve team have {ReserveTeam.Count} players";
        }
    }
}

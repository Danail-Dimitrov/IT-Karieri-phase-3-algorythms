using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFootballTeam
{
    class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name; set
            {
                if (value == null || value.Trim().Length == 0)
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public IReadOnlyList<Player> Players()
        {
            return this.players;
        }

        public double GetRating()
        {
            return Math.Round(
                this.players.Select(p => p.GetStatistics()).ToList().Sum()
                / this.players.Count());
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.players.Count(p => p.Name == playerName) == 0)
            {
                throw new ArgumentException("Player does not exists!");
            }
            this.players.RemoveAll(p => p.Name == playerName);
        }
    }
}

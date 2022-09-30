using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessage.invalidName);
                }
                this.name = value;
            }
        }

        public int Raiting
        {
            get
            {
                if (this.players.Count == 0)
                {
                    return 0;
                }
                return (int)Math.Round(this.players.Average(p => p.OveralSkill), 0);
            }
        }
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            var playerRemove = this.players.FirstOrDefault(p => p.Name == name);
            if (playerRemove == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessage.missingPlayer, name, this.Name));
            }
            this.players.Remove(playerRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Raiting}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public Player(string name, Stat stat)
        {
            this.Name = name;
            this.Stat = stat;

        }
        public string Name
        {
            get => this.name;
            private set
            {
                isValidNamePlayer(value);
                this.name = value;
            }
        }
        public Stat Stat { get; set; }
        public double OveralSkill => this.Stat.OverallStats;

        private void isValidNamePlayer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(ExceptionMessage.invalidName);
            }
        }
    }
}

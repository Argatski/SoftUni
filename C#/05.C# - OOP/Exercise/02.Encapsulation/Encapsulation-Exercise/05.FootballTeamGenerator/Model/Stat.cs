using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stat
    {
        private const int minRange = 0;
        private const int maxRange = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                isValidStats(nameof(this.Endurance), value);

                this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                isValidStats(nameof(this.Sprint), value);
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                isValidStats(nameof(this.Dribble), value);
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                isValidStats(nameof(this.Passing), value);
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                isValidStats(nameof(this.Shooting), value);
                this.shooting = value;
            }
        }

        public double OverallStats => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;

        private void isValidStats(string statName, int value)
        {
            if (value < minRange || value > maxRange)
            {
                throw new ArgumentException(string.Format(ExceptionMessage.invalidStats, statName));
            }
        }
    }
}

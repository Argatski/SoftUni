using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Utilities.Messages;
using System;

namespace PlanetWars.Models.MilitaryUnits.Entities
{
    public abstract class MilitaryUnit : IMilitaryUnit
    {

        private double cost;
        private int enduranceLevelPoint;

        protected MilitaryUnit(double cost)
        {
            this.Cost = cost;
            this.enduranceLevelPoint = 1;
        }

        public double Cost
        {
            get => this.cost;
            private set => this.cost = value;
        }

        public int EnduranceLevel => this.enduranceLevelPoint;

        public void IncreaseEndurance()
        {
            if (this.EnduranceLevel == 20)
            {
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }
            this.enduranceLevelPoint++;
        }
    }
}

using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Utilities.Messages;
using System;

namespace PlanetWars.Models.Weapons.Entities
{
    public abstract class Weapon : IWeapon
    {
        private const int minDestructionLevel = 1;
        private const int maxDestructionLevel = 10;

        private int destructionLevel;
        private double price;

        protected Weapon(int destructionLevel, double price)
        {
            Price = price;
            DestructionLevel = destructionLevel;
        }

        public double Price
        {
            get => this.price;
            private set => this.price = value;
        }

        public int DestructionLevel
        {
            get { return destructionLevel; }
            private set
            {
                if (value < minDestructionLevel)
                {
                    throw new ArgumentException(ExceptionMessages.TooLowDestructionLevel);
                }
                else if (value > maxDestructionLevel)
                {
                    throw new ArgumentException(ExceptionMessages.TooHighDestructionLevel);
                }
                destructionLevel = value;
            }
        }
    }
}

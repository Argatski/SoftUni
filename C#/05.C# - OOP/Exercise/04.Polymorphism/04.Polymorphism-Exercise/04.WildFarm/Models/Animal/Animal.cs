using System;
using System.Collections.Generic;
using WildFarm.Models.Animal.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Core
{
    public abstract class Animal :
        IAnimal, IFeedable, ISoundProducable
    {
        private const string invalidFoodException = "{0} does not eat {1}!";

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; protected set; } // private
        public int FoodEaten { get; protected set; } // private
        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PreferredFoods { get; }

        public void Feed(IFood food)
        {
            if (!this.PreferredFoods.Contains(food.GetType()))
            {
                throw new InvalidOperationException(String.Format(invalidFoodException, this.GetType().Name, food.GetType().Name));
            } 
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightMultiplier;
        }

        public abstract string Sound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}

using System;
using System.Collections.Generic;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animal.Contracts
{
    public interface IFeedable
    {
        void Feed(IFood food);
        int FoodEaten { get; }
        double WeightMultiplier { get; }

        ICollection<Type> PreferredFoods { get; }
    }
}

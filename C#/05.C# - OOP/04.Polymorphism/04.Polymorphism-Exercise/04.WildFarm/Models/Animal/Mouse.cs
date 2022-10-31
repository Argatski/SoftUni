using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Mouse : Mammal
    {
        private const double weightConst = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => weightConst;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Vegetable), typeof(Fruit) };

        public override string Sound()
        {
            return "Squeak";
        }
    }
}

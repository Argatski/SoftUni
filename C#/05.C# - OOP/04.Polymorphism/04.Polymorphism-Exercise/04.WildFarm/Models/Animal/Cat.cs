using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Cat : Feline
    {
        private const double weightConst = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => weightConst;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Vegetable), typeof(Meat) };

        public override string Sound()
        {
            return "Meow";
        }
    }
}

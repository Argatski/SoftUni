using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Dog : Mammal
    {
        private const double weightConst = 0.4;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => weightConst;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat) };
        public override string Sound()
        {
            return "Woof!";
        }
    }
}

using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Hen : Bird
    {
        private const double weightConst = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => weightConst;

        public override ICollection<Type> PreferredFoods =>
           new List<Type>() { typeof(Fruit), typeof(Seeds), typeof(Meat), typeof(Vegetable) };

        public override string Sound()
        {
            return "Cluck";
        }
    }
}

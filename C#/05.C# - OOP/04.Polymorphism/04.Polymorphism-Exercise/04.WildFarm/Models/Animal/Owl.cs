using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Owl : Bird
    {
        private const double weightConst = 0.25;

        public Owl(string name, double weight, double wingSize)
             : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => weightConst;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat) };

        public override string Sound()
        {
            return "Hoot Hoot";
        }
    }
}

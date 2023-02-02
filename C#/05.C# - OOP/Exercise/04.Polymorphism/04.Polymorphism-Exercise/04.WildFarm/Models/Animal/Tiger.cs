using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Tiger : Feline
    {
        private const double weightConst = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => weightConst;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat) };

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}

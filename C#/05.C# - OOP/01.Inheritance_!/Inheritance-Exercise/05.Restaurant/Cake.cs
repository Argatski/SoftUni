using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public const double grams = 250;
        public const double calories = 1000;
        public const decimal Cakeprices = 5M;

        public Cake(string name)
            : base(name, Cakeprices, grams, calories)
        {

        }
    }
}

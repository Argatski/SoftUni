using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies.Entity
{
    public class Stolen : Delicacy
    {
        private const double ConstStolen = 3.50;
        public Stolen(string name) : base(name, ConstStolen)
        {
        }
    }
}

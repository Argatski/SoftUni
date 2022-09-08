using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        //Constructor
        public Beverage(string name, decimal price, double milliliers)
            : base(name, price)
        {
            this.Milliliers = milliliers;
        }
        //Properties
        public double Milliliers { get; set; }
    }
}

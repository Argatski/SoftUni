﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliers)
            : base(name, price, milliliers)
        {
        }
    }
}

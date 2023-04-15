using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies.Entity
{
    public class Gingerbread : Delicacy
    {
        private const double ConstGingerBread = 4.00;
        public Gingerbread(string name) : base(name, ConstGingerBread)
        {
        }
    }
}

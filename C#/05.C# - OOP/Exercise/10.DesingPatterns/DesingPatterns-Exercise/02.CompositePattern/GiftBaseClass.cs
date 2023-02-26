using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompositePattern
{
   public abstract class GiftBaseClass
    {
        public GiftBaseClass(string name,int price)
        {
            Name = name;
            this.Price = price;   
        }
        public string Name { get; set; }

        public int Price { get; set; }

        public abstract int CalculateTotalPrice();
    }
}

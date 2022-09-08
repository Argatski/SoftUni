using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        /*
        public override string ToString()
        {
            return $"Type:{GetType().Name} Name:{Name} Price{Price}";
        }
        */
    }
}

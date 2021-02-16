using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ShoppingSpree
{
    class Product
    {
        public string NameProduct { get; set; }
        public decimal Cost { get; set; }

        public Product(string name,decimal cost)
        {
            NameProduct = name;
            Cost = cost;
        }
    }
}

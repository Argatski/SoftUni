using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ShoppingSpree
{
    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }

        public List<string> BagOfProducts;

        public Person(string name,decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }
        public override string ToString()
        {
            if (BagOfProducts.Count==0)
            {
                return $"{Name} - Nothing bought";
            }
            return $"{Name} - {string.Join(", " , BagOfProducts)}"; 
        }
    }
}

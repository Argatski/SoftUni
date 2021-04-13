using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            string input = string.Empty;

            SortedDictionary<string, Dictionary<string, double>> foodShops = new SortedDictionary<string, Dictionary<string, double>>();

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] arg = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);


                //Processing
                Processing(arg, foodShops);

            }

            //Print all food shops in ordered by shop name
            Print(foodShops);
        }

        private static void Print(SortedDictionary<string, Dictionary<string, double>> foodShops)
        {
            foreach (var nameShop in foodShops)
            {
                Console.WriteLine($"{nameShop.Key}->");

                foreach (var product in nameShop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }

        private static void Processing(string[] arg, SortedDictionary<string, Dictionary<string, double>> foodShops)
        {
            string shopName = arg[0];
            string product = arg[1];
            double price = double.Parse(arg[2]);

            
            if (foodShops.ContainsKey(shopName) == false)
            {
                foodShops.Add(shopName, new Dictionary<string, double>());
            }

            foodShops[shopName][product] = price; //if the product is contained, change the price

        }
    }
}

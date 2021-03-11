using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, Dictionary<int, decimal>> listProduct = new Dictionary<string, Dictionary<int, decimal>>();

            //Solution
            Processing(listProduct);

            //Print

            PrintProduct(listProduct);

        }
        public static void PrintProduct(Dictionary<string, Dictionary<int, decimal>> dict)
        {
            foreach (var kvp in dict)
            {
                int totalQuantity = 0;
                decimal price = 0;

                foreach (var el in kvp.Value) // value off first dictionary
                {
                    totalQuantity += el.Key;
                    price = el.Value;
                }
                decimal totalPrice = totalQuantity * price;
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }


        }

        public static void Processing(Dictionary<string, Dictionary<int, decimal>> list)
        {
            string cmdArgs;

            while ((cmdArgs = Console.ReadLine()) != "buy")
            {
                string[] product = cmdArgs
                    .Split();

                string name = product[0];
                decimal price = decimal.Parse(product[1]);
                int quantity = int.Parse(product[2]);

                if (list.ContainsKey(name))
                {
                    if (list[name].ContainsKey(quantity))
                    {
                        list[name].Add(quantity + quantity, price);
                        list[name].Remove(quantity);
                        continue;
                    }
                    list[name].Add(quantity, price);
                }
                else
                {
                    //var keyDictionary = new Dictionary<int, decimal>()
                    //{
                    //    { quantity,price }
                    //};

                    //list.Add(name, keyDictionary);

                    list[name] = new Dictionary<int, decimal>();
                    list[name].Add(quantity, price);

                }

            }

        }
    }
}

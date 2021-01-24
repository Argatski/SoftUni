using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> listOfProducts = ReadListOfProducts(number);

            PrintByOrder(listOfProducts);
        }

        static void PrintByOrder(List<string> list)
        {
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }

        static List<string> ReadListOfProducts(int num)
        {
            List<string> products = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                products.Add(name);
            }
            return products;
        }
    }
}

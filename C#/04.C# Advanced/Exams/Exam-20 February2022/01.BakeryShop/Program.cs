using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive a sequence of real numbers representing the amount of water, separated by a single space (" ").
            List<double> input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            Queue<double> water = new Queue<double>(input);

            //•	On the second line, you will receive a sequence of real numbers representing the flour, separated by a single space (" ").
            input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            Stack<double> flour = new Stack<double>(input);

            //Processing
            Dictionary<string, int> products = Processing(water, flour);
        }

        private static Dictionary<string, int> Processing(Queue<double> waters, Stack<double> flours)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (waters.Count == 0 && flours.Count == 0)
            {
                double water = waters.Peek();
                double flour = flours.Peek();

                double percentageWater = Calculate(water, flour);
                double percentageFlour = Calculate(flour, water);

                string nameProduct;

                if (percentageWater == 50 && percentageFlour == 50)
                {
                    nameProduct = "Croissant";

                    AddProduct(result, nameProduct);

                }
                else if (percentageWater == 40 && percentageFlour == 60)
                {
                    nameProduct = "Muffin";

                    AddProduct(result, nameProduct);
                }
                else if (percentageWater == 30 && percentageFlour == 70)
                {
                    nameProduct = "Baguette";

                    AddProduct(result, nameProduct);
                }
                else
                {
                    nameProduct = "Croissant";

                    AddProduct(result, nameProduct);
                }
            }

            return result;

        }

        /// <summary>
        /// Add product in dictionary
        /// </summary>
        /// <param name="result"></param>
        /// <param name="nameProduct"></param>
        private static void AddProduct(Dictionary<string, int> result, string nameProduct)
        {
            if (result.ContainsKey(nameProduct))
            {
                result[nameProduct]++;
            }
            else
            {
                result.Add(nameProduct, 1);
            }
        }

        /// <summary>
        /// Calculate the percentage of the product.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private static double Calculate(double first, double second)
        {
            double sum = first + second;

            double result = (first / sum) * 100;

            return result;
        }
    }
}

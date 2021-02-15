using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Pattern
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";

            List<string> product = new List<string>();

            decimal totalPrice = 0.0m;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match currentMatch = Regex.Match(input, pattern);

                if (currentMatch.Success)
                {
                    totalPrice += decimal.Parse(currentMatch.Groups["price"].Value)
                        *int.Parse(currentMatch.Groups["quantity"].Value);

                    product.Add(currentMatch.Groups["name"].Value);
                }
            }

            Console.WriteLine($"Bought furniture:");

            foreach (var item in product)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input text
            string text = Console.ReadLine();

            //Procesing
            Proceessing(text);
        }

        static void Proceessing(string text)
        {
            //Pattern
            string pattern = @"([|]|[#]{1,2})(?<food>[A-Za-z ]+)(\1)(?<data>[\d]{2}[\/][\d]{2}[\/][\d]{2})\1(?<calories>[\d]+)\1";

            Regex rgx = new Regex(pattern);

            int dailyCalories = 2000;

            //Matches all word in text with pattern
            MatchCollection matches = rgx.Matches(text);

            int totalCalories = 0;

            foreach (Match product in matches)
            {
                totalCalories += int.Parse(product.Groups["calories"].Value);
            }

            int days = totalCalories / dailyCalories;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match product in matches)
            {
                Console.WriteLine($"Item: {product.Groups["food"].Value}, Best before: {product.Groups["data"].Value}, Nutrition: {product.Groups["calories"].Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            //Input 
            int n = int.Parse(Console.ReadLine());

            Dictionary<string/*color*/, Dictionary</*tyoe*/string, int/*count*/>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            //Processing
            Processing(n, wardrobe);

            //Print result
            Print(wardrobe);

        }

        /// <summary>
        /// Print all the items and their count for each color in the following format: 
        ///"{color} clothes:
        /// * {item1} - {count}
        /// </summary>
        /// <param name="wardrobe"></param>
        private static void Print(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] clothing = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string color = clothing[0];
            string clothes = clothing[1];

            foreach (var c in wardrobe)
            {
                Console.WriteLine($"{c.Key} clothes:");

                //If you find the item you are looking for, you need to print "(found!)" next to it:
                if (c.Key == color)
                {
                    foreach (var cl in c.Value)
                    {
                        if (cl.Key == clothes)
                        {
                            Console.WriteLine($"* {cl.Key} - {cl.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {cl.Key} - {cl.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var cl in c.Value)
                    {
                        Console.WriteLine($"* {cl.Key} - {cl.Value}");
                    }
                }
            }
        }

        /// <summary>
        /// Clothes to wear from your wardrobe
        /// </summary>
        /// <param name="n"></param>
        /// <param name="wardrobe"></param>
        private static void Processing(int n, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    AddClothes(input, wardrobe);
                }
                else
                {
                    AddClothes(input, wardrobe);
                }

            }
        }

        /// <summary>
        /// Add clothes in current colors
        /// </summary>
        /// <param name="clothes"></param>
        /// <param name="wardrobe"></param>
        private static void AddClothes(string[] input, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string color = input[0];

            string[] clothes = input[1]
                .Split(",", StringSplitOptions.RemoveEmptyEntries);

            for (int c = 0; c < clothes.Length; c++)
            {
                string currentClothes = clothes[c];

                if (wardrobe[color].ContainsKey(currentClothes) == false)
                {
                    wardrobe[color].Add(currentClothes, 0);
                }
                wardrobe[color][currentClothes]++;
            }
        }
    }
}


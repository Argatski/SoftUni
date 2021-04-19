using System;
using System.Collections.Generic;

namespace _05.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            //Processing
            Processing(n, wardrobe);

            //Print result
            Print(wardrobe);

        }

        static void Print(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] needClothing = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string color = needClothing[0];
            string drees = needClothing[1];

            foreach (var col in wardrobe)
            {
                Console.WriteLine($"{col.Key} clothes:");
                if (col.Key==color)
                {
                    foreach (var item in col.Value)
                    {
                        if (item.Key==drees)
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value}");
                        }
                    }
                }

                else
                {
                    foreach (var item in col.Value)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }

        

        static void Processing(int n, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

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

        static void AddClothes(string[] input, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string color = input[0];

            string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

            for (int c = 0; c < clothes.Length; c++)
            {
                if (wardrobe[color].ContainsKey(clothes[c]) == false)
                {
                    wardrobe[color].Add(clothes[c], 0);
                }
                wardrobe[color][clothes[c]]++;
            }
        }
    }
}

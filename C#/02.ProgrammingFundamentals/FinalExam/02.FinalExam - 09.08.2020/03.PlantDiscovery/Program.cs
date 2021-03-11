using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            //Input all plant in dicitonary
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            dict = Information(number);

            //Processing
            Processing(dict);

            //Print 
            PrintPlant(dict);

        }

        static void PrintPlant(Dictionary<string, List<int>> dict)
        {
            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();

            foreach (var name in dict)
            {
                double rarity = 0;
                if (name.Value.Count > 1)
                {
                    rarity = name.Value.Skip(1).Average();
                }
                result.Add(name.Key, new List<double>() { name.Value[0], rarity });
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in result.OrderByDescending(v => v.Value[0]).ThenByDescending(v => v.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }

        private static void Processing(Dictionary<string, List<int>> dict)
        {
            string arg = string.Empty;
            while ((arg = Console.ReadLine()) != "Exhibition")
            {
                char[] symbols = { ' ', ',', ':', '-' };

                string[] command = arg
                    .Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(command[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (command[0])
                {
                    case "Rate":
                        RatePlants(command, dict);
                        break;
                    case "Update":
                        UpdatePlants(command, dict);
                        break;

                    case "Reset":
                        ResetPlants(command, dict);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }

        static void ResetPlants(string[] command, Dictionary<string, List<int>> dict)
        {
            /*remove all the ratings of the given plant*/
            string name = command[1];
            int lenght = dict[name].Count - 1;

            dict[name].RemoveRange(1, lenght);

        }

        static void UpdatePlants(string[] command, Dictionary<string, List<int>> dict)
        {
            /*update the rarity of the plant with the new one*/
            string name = command[1];
            int newRarity = int.Parse(command[2]);

            dict[name][0] = newRarity;
        }

        static void RatePlants(string[] command, Dictionary<string, List<int>> dict)
        {
            /*add the given rating to the plant (store all ratings)*/

            string name = command[1];
            int rating = int.Parse(command[2]); // maybe is double


            if (dict.ContainsKey(name))
            {
                dict[name].Add(rating);
            }
        }

        static Dictionary<string, List<int>> Information(int number)
        {
            var dict = new Dictionary<string, List<int>>();

            for (int i = 0; i < number; i++)
            {
                string[] plant = Console.ReadLine()
                    .Split("<->");

                string name = plant[0];
                int rarity = int.Parse(plant[1]);

                if (dict.ContainsKey(name))
                {
                    dict[name][0] = rarity;
                }
                else
                {
                    dict.Add(name, new List<int>() { rarity });
                }
            }

            return dict;
        }

    }
}

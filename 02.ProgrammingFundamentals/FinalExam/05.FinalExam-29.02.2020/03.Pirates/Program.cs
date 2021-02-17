using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            var towns = new Dictionary</*name*/string, Dictionary</*population*/int,/*gold*/int>>();

            //Solution
            InformationTown(towns);

            Processing(towns);

            //Print collection
            Print(towns);

        }

        static void Print(Dictionary<string, Dictionary<int, int>> towns)
        {
            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

            //worldPopulation = worldPopulation.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value.OrderByDescending(y => y.Value).ToDictionary(y => y.Key, y => y.Value));
            towns = towns.OrderByDescending(v => v.Value.Values.Sum()).ToDictionary(k=>k.Key,v=>v.Value.OrderByDescending(v=>v.Value).OrderBy(k=>k.Key).ToDictionary(y=>y.Key,v=>v.Value));

            foreach (var kvp in towns)
            {
                foreach (var vp in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {vp.Key} citizens, Gold: {vp.Value} kg");
                }
            }
        }

        static void Processing(Dictionary<string, Dictionary<int, int>> towns)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command
                    .Split("=>");

                string events = args[0];

                switch (events)
                {
                    case "Plunder":
                        Plunder(args, towns);
                        break;

                    case "Prosper":
                        Prosper(args, towns);
                        break;
                }
            }
        }

        static void Prosper(string[] args, Dictionary<string, Dictionary<int, int>> towns)
        {
            string town = args[1];
            int gold = int.Parse(args[2]);

            if (gold < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
            }
            else
            {
                foreach (var item in towns[town].Keys)
                {
                    int currentGold = towns[town][item]+gold;
                    towns[town][item] = currentGold;
                    Console.WriteLine($"{gold} gold added to the city treasury. Santo Domingo now has {currentGold} gold.");
                    break;
                }
            }
        }

        static void Plunder(string[] args, Dictionary<string, Dictionary<int, int>> towns)
        {
            string town = args[1];
            int peopleKill = int.Parse(args[2]);
            int gold = int.Parse(args[3]);

            if (towns.ContainsKey(town))
            {
                foreach (var item in towns[town])
                {
                    if (item.Key > 0 && item.Value > 0)
                    {
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {peopleKill} citizens killed.");
                        int currentPopulation = item.Key - peopleKill;
                        int currentGold = item.Value - gold;

                        towns[town].Remove(item.Key);

                        towns[town][currentPopulation] = currentGold;

                        if (currentGold <= 0 || currentPopulation <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            towns.Remove(town);
                        }
                        break;

                    }
                    //This test maybe is not valid because input is aways corect.
                    /*else
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        towns.Remove(town);
                        break;
                    }*/
                }
            }
        }

        static void InformationTown(Dictionary<string, Dictionary<int, int>> towns)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] args = input.Split("||");

                string name = args[0];
                int population = int.Parse(args[1]);
                int gold = int.Parse(args[2]);

                if (towns.ContainsKey(name))
                {
                    foreach (var item in towns[name])
                    {
                        int currGold = item.Value;
                        int currPopulation = item.Key;

                        towns[name].Remove(currPopulation);
                        
                        towns[name][population+currPopulation] = currGold + gold;
                        break;
                    }
                }
                else
                {
                    towns[name] = (new Dictionary<int, int>() { { population, gold } });
                }
            }
        }
    }
}

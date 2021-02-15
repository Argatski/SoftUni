using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, Dictionary<string, long>> popultions = new Dictionary<string, Dictionary<string, long>>();

            //Solution
            AddPopulationInDict(popultions);

            //Print
            PrintResult(popultions);

        }

        static void PrintResult(Dictionary<string, Dictionary<string, long>> popultions)
        {

            foreach (var kvp in popultions.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");

                foreach (var item in kvp.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }
            }


        }

        static void AddPopulationInDict(Dictionary<string, Dictionary<string, long>> dict)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split("|");

                if (input[0].Equals("report"))
                {
                    break;
                }

                string city = input[0];
                string country = input[1];
                uint population = uint.Parse(input[2]);

                if (dict.ContainsKey(country) == false)
                {
                    dict.Add(country, new Dictionary<string, long>() { { city, population } });
                }
                if (dict[country].ContainsKey(city)==false)
                {
                    dict[country].Add(city, 0);
                }
                dict[country][city] = population;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            //Processing
            Processing(number, dict);

            //Print result
            Print(dict);
        }

        static void Print(Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            foreach (var continetns in dict)
            {
                Console.WriteLine($"{continetns.Key}:");
                foreach (var contries in continetns.Value)
                {
                    Console.Write($"{contries.Key} -> ");
                    Console.WriteLine(string.Join(", ",contries.Value));
                   
                }
                
            }
        }

        static void Processing(int number, Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string cities = input[2];
                //Checked the continetn is have in list
                if (dict.ContainsKey(continent) == false)
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                //Checked the country is have inlist
                if (dict[continent].ContainsKey(country) == false)
                {
                    dict[continent].Add(country, new List<string>());
                }

                dict[continent][country].Add(cities);
            }
        }
    }
}

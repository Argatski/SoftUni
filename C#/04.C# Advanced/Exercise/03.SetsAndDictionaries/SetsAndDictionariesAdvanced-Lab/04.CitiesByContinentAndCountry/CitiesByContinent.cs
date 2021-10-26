using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class CitiesByContinent
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
            foreach (var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");
                
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> ");
                    Console.WriteLine(string.Join(", ",country.Value));
                }
            }
        }

        /// <summary>
        /// Create list of cities by continent and conuntry
        /// </summary>
        /// <param name="number"></param>
        /// <param name="dict"></param>
        static void Processing(int n, Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = arguments[0];
                string country = arguments[1];
                string city = arguments[2];

                //Checked the continetn is have in list
                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                
                //Checked the country is have inlist
                if (dict[continent].ContainsKey(country) == false)
                {
                    dict[continent].Add(country, new List<string>());
                }
                dict[continent][country].Add(city);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numMess = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>()
            {
                ["A"] = new List<string>(),
                ["D"] = new List<string>(),
            };

            //Proccesing
            for (int i = 0; i < numMess; i++)
            {
                string text = Console.ReadLine();

                string message = Decrypt(text); // method


                ExtractEnigma(message, dict);
            }

            //Print dictionary
            PrintResult(dict);

        }

        static void PrintResult(Dictionary<string, List<string>> dict)
        {
            foreach (var plante in dict)
            {
                if (plante.Key == "A")
                {
                    Console.WriteLine($"Attacked planets: {plante.Value.Count}");
                    foreach (var name in plante.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"-> {name}");
                    }
                }
                else
                {
                    Console.WriteLine($"Destroyed planets: {plante.Value.Count}");
                    foreach (var name in plante.Value.OrderBy(n=>n))
                    {
                        Console.WriteLine($"-> {name}");
                    }
                }
            }
        }

        static void ExtractEnigma(string message, Dictionary<string, List<string>> dict)
        {
            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->(?<soldier>(\d+))";

            Match match = Regex.Match(message, pattern);

            if (match.Success)
            {
                string planetName = match.Groups["planet"].Value;
                int population = int.Parse(match.Groups["population"].Value);
                string type = match.Groups["type"].Value;
                int soldier = int.Parse(match.Groups["soldier"].Value);

                if (type == "A")
                {
                    dict["A"].Add(planetName);
                }
                else
                {
                    dict["D"].Add(planetName);
                }
            }
        }

        static string Decrypt(string text)
        {
            string patter = @"[s,t,a,r,S,T,A,R]";
            MatchCollection regex = Regex.Matches(text, patter);

            string messagas = string.Empty;
            int count = regex.Count;

            foreach (var item in text)
            {
                char current = (char)(item - count);
                messagas += current;
            }

            return messagas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            //Solution
            string pattern = @"([\/|=])(?<countries>([A-Z][A-Za-z]{2,}))\1";

            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(text);

            int point = 0;

            List<string> result = new List<string>();

            foreach (Match name in matches)
            {
                point += name.Groups["countries"].Length;
                result.Add(name.Groups["countries"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ",result)}");
            Console.WriteLine($"Travel Points: {point}");
        }
    }
}

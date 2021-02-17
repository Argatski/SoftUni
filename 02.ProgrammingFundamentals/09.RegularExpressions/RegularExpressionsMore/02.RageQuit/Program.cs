using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string input = Console.ReadLine();

            //Solution
            Processing(input);
        }

        static void Processing(string input)
        {
            string pattern = @"(?<letter>[^0-9]*)(?<num>[0-9]*)";

            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(input);

            StringBuilder sb = new StringBuilder();

            string symbol = string.Empty;
            int num = 0;

            for (int i = 0; i < matches.Count-1; i++)
            {
                num = int.Parse(matches[i].Groups["num"].Value);
                symbol = matches[i].Groups["letter"].Value;

                for (int k = 0; k < num; k++)
                {
                    sb.Append(symbol.ToUpper());
                }
            }

            string distinct = new String(sb.ToString().Distinct().ToArray());

            Console.WriteLine($"Unique symbols used: {distinct.Length}");
            Console.WriteLine(sb);
        }
    }
}

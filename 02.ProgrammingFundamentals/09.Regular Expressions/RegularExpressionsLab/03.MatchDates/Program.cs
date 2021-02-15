using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string input = Console.ReadLine();

            //Create Pattern
            string pattern = @"\b(?<day>\d{2})(\/|\.|\-)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);


            /*
            string[] result = regex.Matches(input)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();
            */

            MatchCollection dates = Regex.Matches(input,pattern);

            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

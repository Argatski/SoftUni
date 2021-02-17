using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create pattern 
            string pattern = @"\b(?<name>[A-Z][a-z]+) (?<lastNmae>([A-Z][a-z]+)\b)";
            Regex regex = new Regex(pattern);

            //Input 
            string input = Console.ReadLine();

            //Solution
            ProcessingOfRegex(regex, input);
        }

        static void ProcessingOfRegex(Regex regex, string input)
        {
            MatchCollection machtes = regex.Matches(input);

            Console.WriteLine(string.Join(" ",machtes));

        }
    }
}

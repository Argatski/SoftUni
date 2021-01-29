using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string inputText = Console.ReadLine();

            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            MatchCollection rgx = Regex.Matches(inputText, pattern);

            Console.WriteLine(string.Join(Environment.NewLine,rgx));
        }
    }
}

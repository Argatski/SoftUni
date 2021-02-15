using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pattern 
            string pattern = @"(?<code>[+][359]+)(?<delimited>[ -])[2]\2[0-9]{3}\2[0-9]{4}\b";
            Regex regex = new Regex(pattern);

            //Input
            string phoneNumber = Console.ReadLine();

            //Solution
            GetCorectPhonenumber(pattern, phoneNumber);
        }

        public static void GetCorectPhonenumber(string pattern, string phoneNumber)
        {
            MatchCollection phoneMatches = Regex.Matches(phoneNumber, pattern);
            
            /*Convert to string array if you need
            var result = phoneMatches.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            */

            Console.WriteLine(string.Join(", ",phoneMatches));
        }
    }
}

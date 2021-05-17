using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {


            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
                int count = 0;
                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        /*Regex rx = new Regex(@"(?:[-, \.!?])");

                        MatchCollection mathces = rx.Matches(line);*/
                        string replacedLine = ReplacedSymbol(line);

                        string[] reversedLine = replacedLine.Split().Reverse().ToArray();

                        Console.WriteLine(string.Join(" ", reversedLine));
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }
        }

        private static string ReplacedSymbol(string line)
        {
            return line
                 .Replace("-", "@")
                 .Replace(",", "@")
                 .Replace(", ", "@")
                 .Replace(".", "@")
                 .Replace("!", "@")
                 .Replace("?", "@");
        }
    }
}

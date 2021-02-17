using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            string[] text = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);


            //Solution
            List<char> letter = ExtractCapitalLetter(text[0]);

            Dictionary<char, int> wordsLenght = ExtractWordsLength(text[1]);

            foreach (var kvp in wordsLenght)
             {
                 if (!letter.Contains(kvp.Key))
                 {
                     wordsLenght.Remove(kvp.Key);
                 }
             }

            List<string> words = ExtractWords(wordsLenght, text[2]);

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }

        static List<string> ExtractWords(Dictionary<char, int> dict, string v)
        {
            List<string> words = new List<string>();

            string pattern = @"(?<sep>[ ])(?<word>([A-Z][^\d ]+))\b";

            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(v);

            foreach (Match word in matches)
            {
                string current = word.Groups["word"].Value;

                foreach (var kvp in dict)
                {
                    if (current.Contains(kvp.Key) && current.Length == kvp.Value)
                    {
                        words.Add(current);
                        break;
                    }

                }
            }

            return words;
        }

        static Dictionary<char, int> ExtractWordsLength(string v)
        {
            Dictionary<char, int> startLetterLenght = new Dictionary<char, int>();

            string pattern = @"(?<ascii>[6-9][0-9]):(?<lenght>[0-1][0-9])";

            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(v);

            foreach (Match item in matches)
            {
                char symbol = (char)(int.Parse(item.Groups["ascii"].Value));
                int lenght = int.Parse(item.Groups["lenght"].Value);

                if (startLetterLenght.ContainsKey(symbol) == false)
                {
                    startLetterLenght.Add(symbol, lenght + 1);

                }
            }

            return startLetterLenght;
        }

        private static List<char> ExtractCapitalLetter(string v)
        {
            //Output
            List<char> letter = new List<char>();

            //Pattern
            string pattern = @"(?<sum>[#$%*&])(?<first>[A-Z]+)(\k<sum>)";

            Regex rgx = new Regex(pattern);

            Match matches = rgx.Match(v);

            foreach (char item in matches.Groups["first"].Value)
            {
                letter.Add(item);
            }

            return letter;
        }
    }

    //Another solution whit more functional REGEX
    /*
using System;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string firstPattern = @"([#$%*&])(?<capitals>[A-Z]+)(\1)";
            Match firstMatch = Regex.Match(firstPart, firstPattern);
            string capitals = firstMatch.Groups["capitals"].Value;

            for (int index = 0; index < capitals.Length; index++)
            {
                char startLetter = capitals[index];
                int ASCIIcode = startLetter;

                string secondPattern = $@"{ASCIIcode}:(?<length>[0-9][0-9])";
                Match secondMatch = Regex.Match(secondPart, secondPattern);
                int length = int.Parse(secondMatch.Groups["length"].Value);

                string thirdPattern = $@"(?<=\s|^){startLetter}[^\s]{{{length}}}(?=\s|$)";
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
                string word = thirdMatch.ToString();

                Console.WriteLine(word);
            }
        }
    }
}
     
  */
}

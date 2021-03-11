using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string inputText = Console.ReadLine();


            //Solution
            BigInteger multiplying = ThresholdCool(inputText);

            CoolEmoji(inputText, multiplying);



        }

        static void CoolEmoji(string inputText, BigInteger mutiplying)
        {
            List<string> name = new List<string>();

            string patternEmoji = @"([*]{2}|[:]{2})(?<emoji>[A-Z][a-z]{2,})(\1)";

            Regex rgxEmoji = new Regex(patternEmoji);

            MatchCollection matchesEmoji = rgxEmoji.Matches(inputText);

            Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in matchesEmoji)
            {
                BigInteger sum = 0; // maybe is int

                sum = emoji.Groups["emoji"].Value.Sum(c => c);

                if (mutiplying <= sum)
                {
                    Console.WriteLine(emoji );
                }

            }

        }

        private static BigInteger ThresholdCool(string inputText)
        {
            string patternNum = @"[0-9]+";

            Regex rgxNum = new Regex(patternNum);

            MatchCollection matchesNum = rgxNum.Matches(inputText);

            BigInteger result = 1;

            foreach (Match num in matchesNum)
            {
                string current = num.Groups[0].Value;
                for (int i = 0; i < current.Length; i++)
                {
                    int number = int.Parse(current[i].ToString());
                   result *= number;
                    
                }
            }

            Console.WriteLine($"Cool threshold: {result}");

            return result;
        }
    }
}

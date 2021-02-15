using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                ["|"] = ' ',
                [".-"] = 'A',
                ["-..."] = 'B',
                ["-.-."] = 'C',
                ["-.."] = 'D',
                ["."] = 'E',
                ["..-."] = 'F',
                ["--."] = 'G',
                ["...."] = 'H',
                [".."] = 'I',
                [".---"] = 'J',
                ["-.-"] = 'K',
                [".-.."] = 'L',
                ["--"] = 'M',
                ["-."] = 'N',
                ["---"] = 'O',
                [".--."] = 'P',
                ["--.-"] = 'Q',
                [".-."] = 'R',
                ["..."] = 'S',
                ["-"] = 'T',
                ["..-"] = 'U',
                ["...-"] = 'V',
                [".--"] = 'W',
                ["-..-"] = 'X',
                ["-.--"] = 'Y',
                ["--.."] = 'Z'
            };
            string[] moreseCodeSplitt = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            PrintOutput(moreseCodeSplitt, morseCode);

        }

        static void PrintOutput(string[] moreseCodeSplitt, Dictionary<string, char> morseCode)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < moreseCodeSplitt.Length; i++)
            {
                sb.Append(morseCode[moreseCodeSplitt[i]]); 
            }
            Console.WriteLine(sb);
        }
    }
}

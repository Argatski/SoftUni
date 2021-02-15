using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = "abv>1>1>2>2asdasd";

            //Solution
            ProcessingOfExplosion(text);
        }

        static void ProcessingOfExplosion(string text)
        {
            int residue = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (current == '>')
                {
                    residue += text[i + 1] - '0';

                    continue;
                }
                else if (residue > 0)
                {
                    text = text.Remove(i, 1);
                    residue--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }

        //Another Solution
        /*
         static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += GetSumFromCurrentPart(input[i]);
            }

            Console.WriteLine($"{sum:F2}");
        }

        static double GetSumFromCurrentPart(string word)
        {
            double sum = 0;
            char firstCharacter = word[0];
            char lastCharacter = word[word.Length - 1];
            double numberInMiddle = GetNumberInMiddle(word);

            if (char.IsUpper(firstCharacter))
            {
                int firstCharacterPositionInAlphabet = firstCharacter - 64;
                sum += numberInMiddle / firstCharacterPositionInAlphabet;
            }
            else
            {
                int firstCharacterPositionInAlphabet = firstCharacter - 96;
                sum += numberInMiddle * firstCharacterPositionInAlphabet;
            }

            if (char.IsUpper(lastCharacter))
            {
                int lastCharacterPositionInAlphabet = lastCharacter - 64;
                sum -= lastCharacterPositionInAlphabet;
            }
            else
            {
                int lastCharacterPositionInAlphabet = lastCharacter - 96;
                sum += lastCharacterPositionInAlphabet;
            }

            return sum;
        }

        static int GetNumberInMiddle(string word)
        {
            string numberAsString = string.Empty;
            for (int i = 1; i < word.Length - 1; i++)
            {
                numberAsString += word[i];
            }

            return int.Parse(numberAsString);
        }
         */
    }
}

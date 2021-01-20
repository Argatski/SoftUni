using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCharacters = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < numberCharacters; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sum += letter;
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}

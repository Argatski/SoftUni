using System;
using System.Numerics;

namespace _02._01ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Solution
            ConvertFromBaseBase10(input);
        }

        static void ConvertFromBaseBase10(string[] input)
        {
            int baseN = int.Parse(input[0]);
            string number = input[1];

            BigInteger base10 = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentNum = number[number.Length - i - 1] - '0';
                base10 += currentNum * (BigInteger)((Math.Pow(baseN, i)));
            }

            Console.WriteLine(base10);
        }
    }
}

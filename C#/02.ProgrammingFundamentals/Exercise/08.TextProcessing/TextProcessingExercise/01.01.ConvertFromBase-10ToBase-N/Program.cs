using System;
using System.Numerics;

namespace _01._01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //Solution
            ConvertFromBase_N(input);
        }


        static void ConvertFromBase_N(string[] input)
        {
            int numBas = int.Parse(input[0]);
            BigInteger numBase10 = BigInteger.Parse(input[1]);

            string numString = string.Empty;

            while (numBase10 > 0)
            {
                BigInteger remainder = numBase10 % numBas;
                numString = remainder + numString;
                numBase10 /= numBas;
            }
            Console.WriteLine(numString);
        }
        //Another solutio
        /*
        static void ConvertFromBase_N(string[] input)
        {
            int baseN = int.Parse(input[0]);
            BigInteger base10 = BigInteger.Parse(input[1]);

            string number = "";

            while (true)
            {
                var current = base10 % baseN;
                base10 /= baseN;

                number += current;

                if (base10 == 0)
                {
                    break;
                }
            }

            string result = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }

            Console.WriteLine(result);
        }*/
    }
}

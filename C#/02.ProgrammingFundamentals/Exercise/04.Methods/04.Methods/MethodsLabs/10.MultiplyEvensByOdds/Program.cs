using System;
using System.Linq;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numb = int.Parse(Console.ReadLine());
            numb = Math.Abs(numb);

            //Output
            int result = GetMultipleOfEvenAddOdds(numb);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAddOdds(int numb)
        {
            int sumEven = GetSumOfEvensDigits(numb);
            int sumOdd = GetSumOfOddsDigits(numb);

            int getMultipleAll = sumEven * sumOdd;

            return getMultipleAll;
        }

        static int GetSumOfOddsDigits(int numb)
        {
            int sumOfOdds = 0;
            int currentDigit = 0;
            for (int i = 0; i < numb;)
            {
                currentDigit = numb % 10;


                if (currentDigit % 2 != 0)
                {
                    sumOfOdds += currentDigit;
                }
                numb = numb / 10;
            }
            return sumOfOdds;
        }

        static int GetSumOfEvensDigits(int numb)
        {
            int sumOfEven = 0;
            int currentDigit = 0;

            for (int i = 0; i < numb;)
            {
                currentDigit = numb % 10;


                if (currentDigit % 2 == 0)
                {
                    sumOfEven += currentDigit;
                }
                numb = numb / 10;
            }
            return sumOfEven;
        }
    }
}

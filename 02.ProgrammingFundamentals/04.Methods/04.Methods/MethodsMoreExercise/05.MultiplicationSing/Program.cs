using System;

namespace _05.MultiplicationSing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input of 3 numbers
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //Output is a text "negative","positive" or "zero".

            int rezult = MultiplicationSing(num1, num2, num3);

            Console.WriteLine(ChechkingResult(rezult));

        }

        static string ChechkingResult(int rezult)
        {
            string text = string.Empty;
            if (rezult < 0)
            {
                text = "negative";
            }
            else if (rezult > 0)
            {
                text = "positive";
            }
            else
            {
                text = "zero";
            }
            return text;
        }

        static int MultiplicationSing(int num1, int num2, int num3)
        {
            int multiplication = num1 * num2 * num3;
            return multiplication;
        }
    }
}

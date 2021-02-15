using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            //Output
            PrintingTriangle(number);

        }

        //Solution
        private static void PrintingTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintLine(1, i);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                PrintLine(1, i);

            }

        }

        static void PrintLine(int v, int i)
        {
            for (int k = v; k <= i; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
}

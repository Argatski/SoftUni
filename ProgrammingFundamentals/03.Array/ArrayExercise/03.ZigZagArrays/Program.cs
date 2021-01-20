using System;
using System.Linq;


namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberLines];
            int[] secondArray = new int[numberLines];

            for (int i = 0; i < numberLines; i++)
            {
                int[] number = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = number[0];
                    secondArray[i] = number[1];
                }
                else
                {
                    firstArray[i] = number[1];
                    secondArray[i] = number[0];
                }
            }

            Console.Write(string.Join(" ", firstArray));
            Console.WriteLine();

            Console.Write(string.Join(" ", secondArray));
            Console.WriteLine();
        }
    }
}

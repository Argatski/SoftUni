using System;
using System.Linq;

namespace _05.TopIntigers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < number.Length; i++)
            {
                bool isItBigger = true;

                for (int r = i+1; r < number.Length; r++)
                {
                    if (number[i] <= number[r])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(number[i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}

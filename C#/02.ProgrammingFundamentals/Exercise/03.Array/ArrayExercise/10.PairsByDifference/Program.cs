using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //read array of numbers from console
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            // read a number which difference is equal to given number.
            int difference = int.Parse(Console.ReadLine());

            //Solution read and chek
            int count = 0;

            for (int i = 0; i < number.Length; i++) //first number of array
            {
                int rezult = 0;
                for (int k = i+1; k < number.Length; k++)//sum and get second number of array
                {
                    rezult = Math.Abs( number[i] - number[k]);
                    if (rezult==difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int length = numbers.Length;
            //int sum = numbers.Sum();

            Console.WriteLine(Operation(numbers,LengthArray));
            Console.WriteLine(Operation(numbers,Sum));
        }

        public static int Operation(int[] num, Func<int[], int> opr) 
        {
            return opr(num);
        }

        public static int Sum(int[] n) 
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }

        public static int LengthArray(int[] arr)
        {
            int length = arr.Count();

            return length;
        }

    }
}

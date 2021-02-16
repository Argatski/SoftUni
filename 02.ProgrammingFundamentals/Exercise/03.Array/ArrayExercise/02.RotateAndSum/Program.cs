using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            int firstNumber;

            int[] rotateAr = numbersArr;
            int[] sum = new int[numbersArr.Length];

            for (int i = 0; i < k; i++)
            {
                firstNumber = rotateAr[rotateAr.Length - 1];
                for (int r = rotateAr.Length - 1; r > 0; r--)
                {
                    rotateAr[r] = rotateAr[r - 1];
                }

                rotateAr[0] = firstNumber;

                for (int arrSum = 0; arrSum < rotateAr.Length; arrSum++)
                {
                    sum[arrSum] += rotateAr[arrSum];
                }

            }

            foreach (var item in sum)
            {
                Console.Write($"{item}"+" ");
            }
            Console.WriteLine();
        }
    }
}

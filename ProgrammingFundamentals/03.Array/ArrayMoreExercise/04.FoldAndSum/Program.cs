using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            

            int[] leftNumber = new int[number.Length / 2];
            int[] rightNumber = new int[number.Length / 2];

            int count =0;

            for (int row = number.Length/4-1; row >=0; row--)
            {
                leftNumber[count] = number[row];
                count++;
            }

            count = number.Length / 2 - 1;
            for (int col = number.Length -number.Length/4; col < number.Length; col++)
            {
                leftNumber[count] = number[col];
                count--;
            }
            count = 0;
            int strat = number.Length / 4;
            int end = number.Length - number.Length / 4;
            for (int i = strat; i < end; i++)
            {
                rightNumber[count] = number[i];
                count++;
            }
            int[] sum = new int[leftNumber.Length];
            for (int i = 0; i < leftNumber.Length; i++)
            {
                sum[i] = leftNumber[i] + rightNumber[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}

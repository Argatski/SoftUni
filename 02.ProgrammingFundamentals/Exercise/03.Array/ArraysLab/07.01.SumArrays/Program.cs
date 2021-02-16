using System;
using System.Linq;

namespace _07._01.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine() // in this task it isn`t nesesary to use "SplitStringOptions"
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxLenght = Math.Max(firstArr.Length, secondArr.Length);

            int[] endArr = new int[maxLenght]; 

            for (int i = 0; i < maxLenght; i++)
            {
                endArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }
            foreach (var item in endArr)
            {
                Console.Write($"{item}"+ " ");
            }
            Console.WriteLine();
        }
    }
}

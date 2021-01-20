using System;
using System.Linq;
namespace _8.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int number = int.Parse(Console.ReadLine());
            int sum =0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                //if (arr[i]==number)
                //{
                //    Console.WriteLine(number);
                //}
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    if (sum==number)
                    {
                        Console.WriteLine(string.Join(" ",arr[i],arr[j]));
                    }
                }
            }
        }
    }
}

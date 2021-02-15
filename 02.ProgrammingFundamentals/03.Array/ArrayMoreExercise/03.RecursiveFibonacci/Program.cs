using System;
using System.Linq;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int []arr = new int[] { 1, 1 };
            int sum=0;

            switch (number)
            {
                case 1: Console.WriteLine("1");break;
                case 2: Console.WriteLine("1");break;
                default:
                    break;
            }
            for (int i = 2; i < number; i++)
            {
                sum = arr[0] + arr[1];
                int[] newArray = new int[] { arr[1], sum };
                arr = newArray;
            }
            Console.WriteLine(sum);
        }
    }
}

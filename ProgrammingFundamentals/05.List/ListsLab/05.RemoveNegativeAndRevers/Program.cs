using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeAndRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();
            //Solution
            RemoveNegativeNumbers(numbers);

            numbers.Reverse();
            //Print Solution
            PrintSolution(numbers);
        }

        static void PrintSolution(List<int> numbers)
        {

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbers));

            }
        }

        static List<int> RemoveNegativeNumbers(List<int> num)
        {

            num.RemoveAll(x => x < 0);
            return num;
        }

        // Another Solution remove negative numbers
        //static List<int> RemoveNegativeNumbers(List<int> num)
        //{

        //    for (int i = 0; i < num.Count; i++)
        //    {
        //        if (num[i] < 0)
        //        {
        //            num.Remove(num[i]);
        //            --i;
        //        }
        //    }
        //    return num;
        //}
    }
}

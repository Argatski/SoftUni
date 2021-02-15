using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> arrays = Console.ReadLine().Split('|')
                .ToList();

            //Solution
            AppendList(arrays);

        }

        static void AppendList(List<string> arr)
        {
            arr.Reverse();

            List<string> numbers = new List<string>();

            foreach (var str in arr)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(' ',numbers));
        }
    }
}

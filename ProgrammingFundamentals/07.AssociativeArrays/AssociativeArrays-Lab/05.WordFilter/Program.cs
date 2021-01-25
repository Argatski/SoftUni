using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Where(n => n.Length % 2 == 0)
               .ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}

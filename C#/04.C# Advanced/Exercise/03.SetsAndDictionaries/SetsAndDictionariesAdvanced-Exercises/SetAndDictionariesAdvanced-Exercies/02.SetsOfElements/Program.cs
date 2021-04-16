using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            //Add "n" set in dicitionary
            int n = numbers[0];
            HashSet<string> nSet = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
                nSet.Add(num);
            }


            //Add "n" set in dicitionary
            int m = numbers[1];
            HashSet<string> mSet = new HashSet<string>();
            for (int i = 0; i < m; i++)
            {
                string num = Console.ReadLine();
                mSet.Add(num);
            }

            nSet.IntersectWith(mSet);

            Console.WriteLine($"{string.Join(" ",nSet)}");
        }
    }
}

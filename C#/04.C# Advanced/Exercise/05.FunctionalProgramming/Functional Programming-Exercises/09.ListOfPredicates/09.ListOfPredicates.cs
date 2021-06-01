using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int endRange = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Select(int.Parse)
                .ToList();

            //Predicate

            List<int> numbers = new List<int>();

            for (int i = 1; i <=endRange; i++)
            {
                numbers.Add(i);
            }

            foreach (var item in dividers)
            {
                Func<int, bool> filter = x => x % item == 0;

                numbers = numbers.Where(filter).ToList();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }

        //Another solution//
        /*
         * static void Main(string[] args)
        {
            //Input
            int endRange = int.Parse(Console.ReadLine());

            List<int> array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Select(int.Parse)
                .ToList();

            //Predicate
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            array.ForEach(d => predicates.Add(x => x % d == 0));

            List<int> result = new List<int>();

            for (int i = 1; i <= endRange; i++)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(" ", result);
        }
         */
    }
}

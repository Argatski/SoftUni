using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;

            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string condition = Console.ReadLine();

            List<int> result = new List<int>();

            Enumerable.Range(input[0], input[1] - input[0] + 1)
                .Where(x => condition == "even" ? isEven(x) : !isEven(x))
                .ToList()
                .ForEach(result.Add);

            Console.WriteLine(String.Join(" ",result));

        }

        /*static void Main(string[] args)
        {
            //Obtain list size
            List<int> listSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string option = Console.ReadLine();

            //Get start and end 
            long min = listSize.Min();
            long max = listSize.Max();

            List<long> list = new List<long>();

            //input numbers in list
            for (long i = min; i <= max; i++)
            {
                list.Add(i);
            }

            //declare predicatate
            Predicate<long> even = x =>
            {
                return x % 2 == 0;
            };

            Predicate<long> odd = x =>
             {
                 return x % 2 != 0;
             };

            //Output processing
            List<long> result = new List<long>();

            if (option=="odd")
            {
                result = list.FindAll(odd);
            }
            else
            {
                result = list.FindAll(even);
            }

            //Print result
            Console.WriteLine(string.Join(" ",result));
        }*/

    }
}

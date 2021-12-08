using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            //Input
            var input = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            int lowerBound = input[0];
            int upperBound = input[1];


            //Solution
            Predicate<int> isEven = x => x % 2 == 0;

            string condition = Console.ReadLine();//Command specifies if you need to list all even or odd numbers in the given range.

            List<int> numbers = new List<int>();

            Enumerable.Range(lowerBound, upperBound - lowerBound + 1)
                .Where(x => condition == "even" ? isEven(x) : !isEven(x))
                .ToList()
                .ForEach(numbers.Add);

            //Print result
            Console.WriteLine(string.Join(" ", numbers));

        }
        
    }
}

// Another solution 
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



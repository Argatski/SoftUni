using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lenght = int.Parse(Console.ReadLine());

            Predicate<string> filterByLenght = l => l.Length <= lenght;

            Console.ReadLine()
                .Split()
                //.Where(l => l.Length <= lenght)
                .Where(s=>filterByLenght(s))
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}



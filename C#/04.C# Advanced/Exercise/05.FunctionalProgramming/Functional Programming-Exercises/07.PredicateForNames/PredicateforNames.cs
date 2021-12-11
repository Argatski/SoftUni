using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateforNames
    {
        static void Main(string[] args)
        {
            //Input
            int lengthName = int.Parse(Console.ReadLine());

            //Use predicate
            Predicate<string> fillter = l => l.Length <= lengthName;
            
            //Solution
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                //.Where(n=> fillter(n)) Another way to filter every name with this length.
                .Where(l => l.Length <= lengthName)
                .ToList();

            //Print result
            Console.WriteLine(string.Join(" ",names));

        }
    }
}

/*Another way
//Input
            int lenght = int.Parse(Console.ReadLine());

            Predicate<string> filterByLenght = l => l.Length <= lenght;

            Console.ReadLine()
                .Split()
                //.Where(l => l.Length <= lenght)
                .Where(s=>filterByLenght(s))
                .ToList()
                .ForEach(Console.WriteLine); 
 */



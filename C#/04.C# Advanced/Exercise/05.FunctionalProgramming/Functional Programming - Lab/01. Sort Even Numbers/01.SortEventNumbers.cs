using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] evenNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                //.Select(n => int.Parse(n)) // Another solution for parse string to number
                .Select(Parser)
                .Where(EvenNumber)
                //.Where(n => n % 2 == 0) //Another Splution use Func to get eveen number
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", evenNumbers));
        }

        public static Func<string, int> Parser = n => int.Parse(n);

        //Another Function parser string to int
        /*public static Func<string, int> IntParser = n =>
            {
                int result = 0;

                if (int.TryParse(n, out result))
                {
                    return result;
                }
                return 0;
            };*/


        public static Func<int, bool> EvenNumber = e => e % 2 == 0;

        /*public static Func<int, bool> EvenNumber = e =>
        {
            return e % 2 == 0;
        };*/

        public static Func<int, int> OrderEven = o => o;
    }
}

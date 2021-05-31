using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divisibleNum = int.Parse(Console.ReadLine());


            Predicate<int> filter = x => x % divisibleNum != 0;
            Func<int, bool> filterFunc = x => filter(x);

            numbers = numbers
                .Where(filterFunc)
                .ToArray();

            numbers = Reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static Func<int[], int[]> Reverse = r =>
        {
            int[] result = new int[r.Length];

            for (int i = 0; i < r.Length; i++)
            {
                result[i] = r[r.Length - i - 1];
            }
            return result;
        };

        //Another solution use lambda.
        /*static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divisibleNum = int.Parse(Console.ReadLine());

            numbers = numbers.Reverse()
                .Where(n => n % divisibleNum != 0)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }*/
    }
}

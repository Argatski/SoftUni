using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //Solution
            int k = numbers.Count / 4;
            int twoK = (numbers.Count / 4) * 2;
            List<int> leftPart = numbers.Take(k)
                .Reverse().ToList();
            List<int> rightPart = numbers.TakeLast(k)
                .Reverse().ToList();

            leftPart = leftPart.Concat(rightPart).ToList();

            numbers = numbers.Skip(k).ToList();
            numbers = numbers.SkipLast(k).ToList();

            var sum = leftPart.Select((x, index) => x + numbers[index]);

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}

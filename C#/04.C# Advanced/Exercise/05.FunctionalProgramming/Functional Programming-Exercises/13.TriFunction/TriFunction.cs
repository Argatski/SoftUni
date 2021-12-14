using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int numberLenght = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> isGreat = (a, b) => a.Sum(c=>c) >= b;

            Func<Func<string, int, bool>, List<string>, string> returnFirst = (a, b) => b.FirstOrDefault(s => a(s, numberLenght));

            string result = returnFirst(isGreat, names);

            if (result!=null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(string.Empty);
            }
        }
    }
}

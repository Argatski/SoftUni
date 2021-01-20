using System;
using System.Linq;

namespace _04.ReversArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine()
                .Split(' ');

            letters = letters.Reverse().ToArray();

            foreach (var idex in letters)
            {
                Console.Write($"{idex}"+" ");
            }
            Console.WriteLine();
        }
    }
}

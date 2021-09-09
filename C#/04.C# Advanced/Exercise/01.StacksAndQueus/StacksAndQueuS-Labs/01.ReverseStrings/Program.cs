using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string input = Console.ReadLine();

            //Solution
            Stack<char> reverseString = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverseString.Push(input[i]);
            }

            while (reverseString.Count>0)
            {
                Console.Write(reverseString.Pop());
            }

            Console.WriteLine();
        }

        //Another solution
        /*Stack<string> r = new Stack<string>(Console.ReadLine().Select(x=>x.ToString()));

        while (r.Count > 0)
        {
            Console.Write(r.Pop());
        }
        Console.WriteLine();*/

    }
}

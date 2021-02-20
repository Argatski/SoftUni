using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            Stack<char> reverese = new Stack<char>();


            for (int i = 0; i < text.Length; i++)
            {
                reverese.Push(text[i]);
            }

            Console.WriteLine(string.Join("", reverese));


            //Another solution
            /*Stack<string> r = new Stack<string>(Console.ReadLine().Select(x=>x.ToString()));

            while (r.Count > 0)
            {
                Console.Write(r.Pop());
            }
            Console.WriteLine();*/
        }
    }
}

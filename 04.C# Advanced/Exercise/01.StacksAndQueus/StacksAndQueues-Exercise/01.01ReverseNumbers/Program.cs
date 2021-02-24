using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._01ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Stack<int> reverseNumber = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (reverseNumber.Count>0)
            {
                Console.Write(reverseNumber.Pop()+" ");
            }
        }
    }
}

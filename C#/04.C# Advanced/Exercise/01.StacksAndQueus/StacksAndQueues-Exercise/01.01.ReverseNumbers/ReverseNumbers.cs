using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._01.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            //Read and reverse
            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            //Print
            Console.WriteLine(string.Join(" ",numbers));


            /*Another Solution
             
             //Input
            Stack<int> reverseNumber = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (reverseNumber.Count>0)
            {
                Console.Write(reverseNumber.Pop()+" ");
            }
             */
        }
    }
}

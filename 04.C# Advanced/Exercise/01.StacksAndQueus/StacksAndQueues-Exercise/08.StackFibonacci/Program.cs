using System;
using System.Collections.Generic;

namespace _08.StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            long numberFibonacci = long.Parse(Console.ReadLine());

            Stack<long> stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            //Processing
            StackFibonnacci(numberFibonacci, stack);

            Console.WriteLine(stack.Pop());

        }

        static void StackFibonnacci(long numberFibonacci, Stack<long> stack)
        {
            for (int i = 0; i < numberFibonacci-1; i++)
            {
                long currentNum = stack.Pop();
                long previous = stack.Peek();

                stack.Push(currentNum);

                long result = currentNum + previous;

                stack.Push(result);
            }
        }
    }
}

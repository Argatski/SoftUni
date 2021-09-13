using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            //Input
            Stack<int> numbers = new Stack<int>();

            int numberOfInput = int.Parse(Console.ReadLine());

            //Solution

            for (int i = 0; i < numberOfInput; i++)
            {
                int[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                /*
                  1 x – Push the element x into the stack.
                  2 – Delete the element present at the top of the stack.
                  3 – Print the maximum element in the stack.
                  4 – Print the minimum element in the stack.
                 */

                int command = arguments[0];

                switch (command)
                {
                    case 1:
                        Push(numbers, arguments[1]);
                        break;
                    case 2:
                        if (numbers.Count>0)
                        {
                            Delete(numbers, command);
                        }
                        break;
                    case 3:
                        //Print maximum element
                        if (numbers.Count>0)
                        {
                            Console.WriteLine($"{numbers.Max()}");
                        }
                        break;
                    case 4:
                        //Print min element
                        if (numbers.Count>0)
                        {
                            Console.WriteLine($"{numbers.Min()}");
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ",numbers));
        }

        static void Delete(Stack<int> numbers, int command)
        {
            numbers.Pop();
        }

        static void Push(Stack<int> numbers, int v)
        {
            numbers.Push(v);
        }
    }
    /*Another solution
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();
            //Processing

            Processing(n, numbers);

            Console.WriteLine(string.Join(", ",numbers));
            
        }

        private static void Processing(int n, Stack<int> numbers)
        {
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int command = array[0];

                switch (command)
                {
                    case 1:
                        numbers.Push(array[1]);
                        break;
                    case 2:
                        if (numbers.Count>0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Count>0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case 4:
                        if (numbers.Count>0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                    default:
                        break;
                }
            }
        }
     */
}

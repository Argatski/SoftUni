using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElements
{
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
    }
}

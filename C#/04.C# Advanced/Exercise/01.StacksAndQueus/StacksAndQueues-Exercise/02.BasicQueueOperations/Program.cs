using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            //Processing

            RemoveCountNumber(numbers, elements[1]);

            ChekedNumberInQueue(numbers, elements[2]);

        }

        private static void ChekedNumberInQueue(Queue<int> numbers, int v)
        {
            if (numbers.Count==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (numbers.Contains(v))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
        }

        private static void RemoveCountNumber(Queue<int> numbers, int v)
        {
            for (int i = 0; i < v; i++)
            {
                numbers.Dequeue();
            }
        }
    }
}

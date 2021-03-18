using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations1
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

            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            //Processing
            int numberPop = elements[1];
            int numberLook = elements[2];

            RemoveElement(numbers, numberPop);

            FoundNumber(numbers, numberLook);

        }

        static void FoundNumber(System.Collections.Generic.Stack<int> numbers, int numberLook)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (numbers.Contains(numberLook))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
        }

        private static void RemoveElement(Stack<int> numbers, int numberPop)
        {
            for (int i = 0; i < numberPop; i++)
            {
                numbers.Pop();
            }


        }
    }
}

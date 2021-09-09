using System;
using System.Collections.Generic;

namespace _02._01.DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int decimalNumber = int.Parse(Console.ReadLine());


            //Solution
            Stack<string> binary = new Stack<string>();

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                while (decimalNumber > 0)
                {
                    int divide = decimalNumber % 2;
                    decimalNumber /= 2;

                    binary.Push(divide.ToString());
                }

            }

            //Print solution
            while (binary.Count > 0)
            {
                Console.Write(binary.Pop());
            }
            Console.WriteLine();
        }
    }
}

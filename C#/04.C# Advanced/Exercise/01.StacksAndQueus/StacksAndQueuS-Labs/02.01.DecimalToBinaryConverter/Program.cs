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

            Stack<int> binaryNumber = new Stack<int>();

            if (decimalNumber==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (decimalNumber>0)
                {
                    int divide =  decimalNumber % 2;

                    decimalNumber /= 2;

                    binaryNumber.Push(divide);
                }

            }

            while (binaryNumber.Count>0)
            {
                Console.Write(binaryNumber.Pop());
            }
            Console.WriteLine();
        }
    }
}

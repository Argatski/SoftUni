using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] input = Console.ReadLine()
                .Split(" ");

            //Solution
            Stack<string> calculator = new Stack<string>(input.Reverse());

            while (calculator.Count>1)
            {
                int firstNum = int.Parse(calculator.Pop());
                string operand = calculator.Pop();
                int seconNum = int.Parse(calculator.Pop());


                if (operand=="+")
                {
                    int result = firstNum + seconNum;
                    calculator.Push(result.ToString());
                }
                else if (operand=="-")
                {
                    int result = firstNum - seconNum;
                    calculator.Push(result.ToString());
                }
            }

            //Print result
            Console.WriteLine(calculator.Pop());
        }
    }
}

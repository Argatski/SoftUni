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
            Stack<string> simpleCalculator = new Stack<string>(Console.ReadLine().Split().Reverse());


            while (simpleCalculator.Count>1)
            {
                int firstNumber = int.Parse(simpleCalculator.Pop());
                string operand = simpleCalculator.Pop();
                int secondNumber = int.Parse(simpleCalculator.Pop());

                if (operand=="+")
                {
                    int sum = firstNumber + secondNumber;
                    simpleCalculator.Push(sum.ToString());
                }
                else if (operand=="-")
                {
                    int result = firstNumber - secondNumber;
                    simpleCalculator.Push(result.ToString());
                }
            }
            Console.WriteLine(simpleCalculator.Pop());
        }
    }
}

using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string expression = Console.ReadLine();

            //Solution
            Stack<int> positionBrackets = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    positionBrackets.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startExpression = positionBrackets.Pop();
                    int endExpression = i;
                    int lenght = endExpression - startExpression + 1;

                    Console.WriteLine(expression.Substring(startExpression, lenght));
                }
            }
        }
    }
}

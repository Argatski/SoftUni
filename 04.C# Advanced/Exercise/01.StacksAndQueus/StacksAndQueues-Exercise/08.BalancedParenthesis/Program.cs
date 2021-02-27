using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isBalance = true;

            foreach (var ch in text)
            {
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch);
                        break;
                    case ')':
                        if (stack.Any()==false || stack.Pop() != '(')
                        {
                            isBalance = false;
                        }
                        break;
                    case '}':
                        if (stack.Any()==false || stack.Pop() != '{')
                        {
                            isBalance = false;
                        }
                        break;
                    case ']':
                        if (stack.Any()==false || stack.Pop() != '[')
                        {
                            isBalance = false;
                        }
                        break;
                }

            }
            string result = isBalance ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}

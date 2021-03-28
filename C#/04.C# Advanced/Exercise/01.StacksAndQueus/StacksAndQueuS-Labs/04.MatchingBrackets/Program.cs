using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (text[i] == ')')
                {
                    int startIndex = brackets.Pop();
                    Console.WriteLine(text.Substring(startIndex, i - startIndex + 1));
                }
            }

        }
    }
}

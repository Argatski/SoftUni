using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main()
        {
            //Input
            int numberOfOperations = int.Parse(Console.ReadLine());

            Stack<string> text = new Stack<string>();
            text.Push("");

            //Proccesing
            for (int i = 0; i < numberOfOperations; i++)
            {
                var args = Console.ReadLine()
                    .Split();

                switch (args[0])
                {
                    case "1":
                        AppendText(args, text);
                        break;
                    case "2":
                        int count = int.Parse(args[1]);
                        Erases(count, text);
                        break;
                    case "3":
                        int index = int.Parse(args[1]);
                        PrintCharacters(index, text);
                        break;
                    case "4":
                        text.Pop();
                        break;
                }
            }
        }

        private static void PrintCharacters(int index, Stack<string> text)
        {
            string current = text.Peek();
            Console.WriteLine(current.Substring(index-1,1));
        }

        static void Erases(int count, Stack<string> text)
        {
            string privious = text.Peek();

            string substring = privious.Substring(0, privious.Length - count);

            text.Push(substring);
        }

        static void AppendText(string[] args, Stack<string> text)
        {
            for (int i = 1; i < args.Length; i++)
            {
                string input = text.Peek() + args[i];
                text.Push(input);
            }
        }
    }
}

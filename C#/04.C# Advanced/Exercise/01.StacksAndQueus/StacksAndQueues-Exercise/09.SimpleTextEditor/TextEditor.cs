using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class TextEditor
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfOperations = int.Parse(Console.ReadLine());

            Stack<string> text = new Stack<string>();

            text.Push("");

            //Processing
            SimpleTextEditor(numberOfOperations, text);
        }

        static void SimpleTextEditor(int numberOfOperations, Stack<string> text)
        {
            for (int i = 0; i < numberOfOperations; i++)
            {
                var args = Console.ReadLine()
                    .Split(" ");

                switch (args[0])
                {
                    //•	1 someString - appends someString to the end of the text
                    case "1":
                        Appends(text, args);
                        break;
                    //•	2 count - erases the last count elements from the text
                    case "2":
                        Erases(text, args);
                        break;
                    //•	3 index - returns the element at index char from the text(if we have “klmn” and we get 3 4, the 4 - th char is ‘n’)
                    case "3":
                        PrintCharacters(text, args);
                        break;
                    //•	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
                    case "4":
                        text.Pop();
                        break;
                        
                }
            }
        }

        private static void PrintCharacters(Stack<string> text, string[] args)
        {
            int index = int.Parse(args[1]);

            string current = text.Peek();
            Console.WriteLine(current.Substring(index - 1, 1));

        }

        private static void Erases(Stack<string> text, string[] args)
        {
            int count = int.Parse(args[1]);

            string privios = text.Peek();

            string subistring = privios.Substring(0, privios.Length - count);

            text.Push(subistring);

        }

        static void Appends(Stack<string> text, string[] args)
        {
            for (int i = 1; i < args.Length; i++)
            {
                string input = text.Peek() + args[i];

                text.Push(input);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Create stack whit numbers
            Stack<int> allNumbers = new Stack<int>(numbers);

            //Solution
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] arguments = command
                    .Split(" ");

                if (arguments.Contains("add"))
                {
                    for (int i = 1; i < arguments.Length; i++)
                    {
                        allNumbers.Push(int.Parse(arguments[i]));
                    }
                }
                else if (arguments.Contains("remove"))
                {
                    int removeNumbers = int.Parse(arguments[1]);
                    if (removeNumbers <= allNumbers.Count)
                    {
                        for (int i = 0; i < removeNumbers; i++)
                        {
                            allNumbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Sum: " + allNumbers.Sum());
        }
        /*Anathor Solution
            //Input
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string arg = string.Empty;

            Stack<int> numbers = new Stack<int>(num);

            while ((arg=Console.ReadLine().ToLower())!="end")
            {
                string[] command = arg.Split();

                switch (command[0])
                {
                    case "add":
                        numbers.Push(int.Parse(command[1]));
                        numbers.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        int count = int.Parse(command[1]);
                        if (count<= numbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        
                        break;
                }
            }
            Console.WriteLine("Sum: " + numbers.Sum());
          */
    }
}

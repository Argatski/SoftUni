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
        }
    }
}

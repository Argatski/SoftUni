using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            Swap<string> swap = new Swap<string>();

            //Input the elements in List<T>
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                swap.Add(input);
            }

            //Read the indexes
            int[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int first = command[0];
            int second = command[1];

            //Swap the elements
            swap.SwapString(first, second);

            //Print result
            swap.Print();
            
        }
    }
}

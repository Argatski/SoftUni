using System;
using System.Collections.Generic;

namespace _07.HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            //Solution
            Queue<string> children = new Queue<string>(names);

            while (children.Count > 1)
            {

                for (int i = 1; i < n; i++)
                {
                    string first = children.Dequeue();
                    children.Enqueue(first);
                }
                //Print loss
                Console.WriteLine("Removed " + children.Dequeue()); 
            }

            //Print winner
            Console.WriteLine("Last is " + children.Dequeue());

        }

        /*Another solution
             //Input
            Queue<string> array = new Queue<string>(Console.ReadLine()
                .Split());

            int n = int.Parse(Console.ReadLine());

            int count = 0;

            while (array.Count>1)
            {
                count++;

                if (n==count)
                {
                    Console.WriteLine($"Removed {array.Dequeue()}");
                    count = 0;
                }
                else
                {
                    string name = array.Dequeue();
                    array.Enqueue(name);
                }
            }
            Console.WriteLine($"Last is {array.Dequeue()}");
            */
    }
}

using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

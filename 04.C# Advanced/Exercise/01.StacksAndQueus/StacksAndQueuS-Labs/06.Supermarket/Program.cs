using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string name = string.Empty;

            Queue<string> people = new Queue<string>();

            while ((name = Console.ReadLine())!="End")
            {
                
                if (name=="Paid")
                {
                    while (people.Count>0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(name);
                }
            }
            Console.WriteLine($"{people.Count} people remaining.");

        }
    }
}

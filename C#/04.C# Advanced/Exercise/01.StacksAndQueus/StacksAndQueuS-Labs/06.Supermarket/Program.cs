using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            //Solution
            Processing(people);

            //Print 
            Printing(people);
        }

         static void Printing(Queue<string> people)
        {
            Console.WriteLine(people.Count + " people remaining.");
        }

        static void Processing(Queue<string> people)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input=="Paid")
                {
                    while (people.Count>0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(input);
                }

            }
        }
    }
}

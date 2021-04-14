using System;
using System.Collections.Generic;

namespace _05.RecordUniqueName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            //Processing
            Processing(num, names);

            //Print
            Print(names);

        }

        private static void Print(HashSet<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }
        }

        static void Processing(int num, HashSet<string> names)
        {
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            HashSet<string> users = new HashSet<string>();

            //Processing
            Processing(number, users);

            //Print result
            Print(users);
        }

        private static void Print(HashSet<string> users)
        {
            foreach (var name in users)
            {
                Console.WriteLine(name);
            }
        }

        private static void Processing(int number, HashSet<string> users)
        {
            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                users.Add(name);
            }
        }
    }
}

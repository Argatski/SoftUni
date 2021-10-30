using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class UniqueUserNames
    {
        static void Main(string[] args)
        {
            //Input 
            int numberUserNames = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            //Processing
            Processing(numberUserNames, uniqueNames);

            //Print result
            PrintUniqueNames(uniqueNames);

        }

        /// <summary>
        /// Print unique names
        /// </summary>
        /// <param name="uniqueNames"></param>
        static void PrintUniqueNames(HashSet<string> uniqueNames)
        {
            foreach (var name in uniqueNames)
            {
                Console.WriteLine($"{name}");
            }
        }

        /// <summary>
        /// Create list unique user
        /// </summary>
        /// <param name="numberUserNames"></param>
        /// <param name="uniqueNames"></param>
        static void Processing(int numberUserNames, HashSet<string> uniqueNames)
        {
            for (int i = 0; i < numberUserNames; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }
        }
    }
}



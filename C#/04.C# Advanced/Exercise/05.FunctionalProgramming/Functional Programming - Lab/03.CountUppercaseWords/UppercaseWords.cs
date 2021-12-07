using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class UppercaseWords
    {
        static void Main(string[] args)
        {
            //Input 
            List<string> text =
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                //.Where(UppercaseWords)
                //.Where(Uppercase)
                .Where(w => char.IsUpper(w[0]))
                .ToList();
                //.ForEach(w => Console.WriteLine(w)); Another way to print result.

            //Print uppercase words
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }

        }
        /// <summary>
        /// The function presents all the words that start with an uppercase.
        /// </summary>
        /*public static Func<string, bool> UppercaseWords = u => char.IsUpper(u[0]);*/

        /// <summary>
        /// The function presents all the words that start with an uppercase.
        /// </summary>
        public static Func<string, bool> Uppercase = w =>
        {
            if (char.IsUpper(w[0]))
            {
                return true;
            }
            return false;
        };

    }
}

//Another solution.
/*
  Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(w => char.IsUpper(w[0]))
                .ToList()
                .ForEach(w=>Console.WriteLine(w));
 */

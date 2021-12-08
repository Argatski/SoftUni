using System;

namespace _01.ActionPoint
{
    class ActionPoint
    {
        static void Main(string[] args)
        {
            //Input
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //Print result
            PrintResult(text);

        }
        /// <summary>
        /// The action prints each word on a new line.
        /// </summary>
        public static Action<string[]> PrintResult = text => 
        {
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        };
       
    }
}


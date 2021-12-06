using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class SortEvenNums
    {
        static void Main(string[] args)
        {
            //Input 
            int[] evenNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                //.Select(IntParser)
                .Where(n => n % 2 == 0)
                //.Where(EvenNumbers)
                //.Where(EvenNumbersSecond)
                .OrderBy(n => n)
                //.OrderBy(OrderBy);
                .ToArray();

            //Print result collection
            Console.WriteLine(string.Join(", ", evenNumbers));

        }

        /// <summary>
        /// This function select every string to integer.
        /// </summary>
        public static Func<string, int> Parser = n => int.Parse(n);

        /// <summary>
        /// This function select every strung to integer.
        /// </summary>
        public static Func<string, int> IntParser = n =>
         {
             int result = 0;

             if (int.TryParse(n, out  result))
             {
                 return result;
             }
             return 0;
         };

        /// <summary>
        /// This function finds which number is even.
        /// </summary>
        public static Func<int, bool> EvenNumbers = n => n % 2 == 0;
    
        /// <summary>
        /// This function finds which number is even.
        /// </summary>
        public static Func<int, bool> EvenNumbersSecond = n =>
         {
             return n % 2 == 0;
         };

         /// <summary>
         /// The function sorted elements in ascending order
         /// </summary>
        public static Func<int, int> OrderBy = o => o;
        
    }
}









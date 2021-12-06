using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumNumbers
{
    class SumNum
    {
        static void Main(string[] args)
        {
            //Input 
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                //.Select(int.Parse)
                //.Select(n=>int.Parse(n))
                .Select(Parser)
                .ToArray();

            /*Length
            int length = numbers.Length;
            Console.WriteLine(length);*/

            //int sum = numbers.Sum();


            //Print result
            Console.WriteLine(Operation(numbers, LengthArray));
            Console.WriteLine(Operation(numbers, Sum));
        }


        /// <summary>
        /// The function converts a string to an integer.
        /// </summary>
        public static Func<string, int> Parser = n =>
        {
            int result = 0;
            if (int.TryParse(n,out result))
            {
                return result;
            }
            return 0;
        };

        /// <summary>
        /// Operation of functions.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="opr"></param>
        /// <returns></returns>
        public static int Operation(int[] num, Func<int[], int> opr)
        {
            return opr(num);
        }

        /// <summary>
        /// Sum of array.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }

        /// <summary>
        /// Length of array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int LengthArray(int[] arr)
        {
            int length = arr.Count();

            return length;
        }

    }
}

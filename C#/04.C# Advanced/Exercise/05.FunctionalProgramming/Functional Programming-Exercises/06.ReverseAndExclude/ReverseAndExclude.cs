using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            //Input
            int[] number = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int divisibleNum = int.Parse(Console.ReadLine());

            //Removes elements that are divisible 
            Predicate<int> fillter = n => n % 2 != 0;
            Func<int, bool> filterFunc = x => fillter(x);

            //Reverse
            

            RevereseArray(number);

            number = number.Where(filterFunc).ToArray();

            Console.WriteLine(string.Join(" ", number));
        }

        public static Func<int[], int[]> RevereseArray = n =>
        {
            for (int i = 0; i < n.Length; i++)
            {
                int endNumber = n[n.Length - i];
                int startNumber = n[i];

                n[i] = endNumber;
                n[n.Length - i] = startNumber;
            }
            return n;

            /*Another reverse method
              int[] result = new int[r.Length];

               for (int i = 0; i < r.Length; i++)
               {
                     result[i] = r[r.Length - i - 1];
               }
               return result;
             */
        };

        //Another solution use lambda.
        /*static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divisibleNum = int.Parse(Console.ReadLine());

            numbers = numbers.Reverse()
                .Where(n => n % divisibleNum != 0)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }*/
    }
}

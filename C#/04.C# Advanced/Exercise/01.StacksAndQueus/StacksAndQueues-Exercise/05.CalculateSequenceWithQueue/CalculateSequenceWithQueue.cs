using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CalculateSequenceWithOueue
{
    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            //Input
            long num = long.Parse(Console.ReadLine());

            //Processing
            Queue<long> sequence = new Queue<long>();

            List<long> result = new List<long>();

            sequence.Enqueue(num);
            result.Add(num);

            // index "i" is 17 because we must print its first 50 members for given N. (3*17 = 51)
            for (int i = 0; i < 17; i++)
            {
                long currentNum = sequence.Dequeue();

                long firstNum = currentNum + 1;
                sequence.Enqueue(firstNum);

                long secondNum = 2 * currentNum + 1;
                sequence.Enqueue(secondNum);

                long thirdNum = currentNum + 2;
                sequence.Enqueue(thirdNum);

                result.Add(firstNum);
                result.Add(secondNum);
                result.Add(thirdNum);

            }


            //Print result
            Console.WriteLine(string.Join(" ", result.Take(50)));

        }
    }
}

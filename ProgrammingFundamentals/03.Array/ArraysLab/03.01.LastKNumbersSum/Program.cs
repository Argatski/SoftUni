using System;

namespace _03._01.LastKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());

            long[] seq = new long[numberN]; /// long because sum grow quickly
            seq[0] = 1;
            
            for (int i = 1; i < numberN; i++)
            {
                long sum = 0;
                for (int k = i - numberK; k < i; k++)
                {
                    if (k >= 0)
                    {
                        sum += seq[k];
                    }
                }
                seq[i] = sum;
                
            }
            foreach (var item in seq)
            {
                Console.Write($"{item}" + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int [] rezult =  TribonacciSequence(num);
            Console.WriteLine(String.Join(" ", rezult));
        }

        static int [] TribonacciSequence(int num)
        {

            int[] sum = new int[num];
            long firstNum = 1;
            long secondNum = 1;

            for (int i = 0; i < num; i++)
            {
                if (i <= 1)
                {
                    sum[i] = 1;
                    continue;
                }
                else if (i==2)
                {
                    sum[i] = sum[i-2]+sum[i-1];
                    continue;

                }
                sum[i] = sum[i - 3] + sum[i - 2] + sum[i-1];

            }
            return sum;
        }
    }
}

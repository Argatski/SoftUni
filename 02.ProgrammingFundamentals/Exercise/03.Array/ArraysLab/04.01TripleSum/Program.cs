using System;
using System.Linq;

namespace _04._01TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = 0;

            for (int i = 0; i <numbers.Length-1; i++)
            {
                int firstNum = numbers[i];
                
                for (int k = i+1; k < numbers.Length; k++)
                {
                    int secondNum = numbers[k];
                    int sum = firstNum+secondNum;

                    if (numbers.Contains(sum))
                    {
                        count++;
                        Console.WriteLine($"{firstNum} + {secondNum} == {firstNum+secondNum}");
                    }
                   
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

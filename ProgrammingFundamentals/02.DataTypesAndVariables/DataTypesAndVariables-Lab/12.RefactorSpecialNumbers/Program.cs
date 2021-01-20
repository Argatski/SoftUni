using System;

namespace _10.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0; int current = 0; bool isTrue = false;
            for (int i = 1; i <= number; i++)
            {
                current = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{current} -> {isTrue}");
                sum = 0;
                i = current;
            }
        }
    }
}

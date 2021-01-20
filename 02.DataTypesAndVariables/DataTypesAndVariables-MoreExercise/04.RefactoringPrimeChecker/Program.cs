using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrme = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPrme = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrme.ToString().ToLower());
            }

        }
    }
}

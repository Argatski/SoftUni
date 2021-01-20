using System;

namespace _08.BeerKengs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            string firstKengsName = Console.ReadLine();
            double firstKengsRadius = double.Parse(Console.ReadLine());
            double firstKengsHeight = double.Parse(Console.ReadLine());
            double firstKengsSum = 0.0;

            double formulaFirst = Math.PI * Math.Pow(firstKengsRadius, 2) * firstKengsHeight;

            double secondKengsSum = 0.0;
            double secondKengsRadius = 0.0;
            double secondKengsHeight = 0.0;
            string secondKengsName = string.Empty;

            for (int i = 1; i < numberLines; i++)
            {
                secondKengsName = Console.ReadLine();
                secondKengsRadius = double.Parse(Console.ReadLine());
                secondKengsHeight = double.Parse(Console.ReadLine());

                secondKengsSum = Math.PI * Math.Pow(secondKengsRadius, 2) * secondKengsHeight;

                if (firstKengsSum <= secondKengsSum)
                {
                    firstKengsName = secondKengsName;
                    firstKengsSum = secondKengsSum;
                }
            }
            Console.WriteLine($"{firstKengsName}");

        }
    }
}

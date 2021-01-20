using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainWagons = int.Parse(Console.ReadLine());

            int[] sumPeople = new int[trainWagons];

            int totalSumPeople = 0;

            for (int i = 0; i < trainWagons; i++)
            {
                int numberPeople = int.Parse(Console.ReadLine());
                sumPeople[i] = numberPeople;
            }

            foreach (var index in sumPeople)
            {
                totalSumPeople += index;
            }
            Console.Write(string.Join(' ', sumPeople));
            Console.WriteLine();
            Console.WriteLine(totalSumPeople);
        }
    }
}


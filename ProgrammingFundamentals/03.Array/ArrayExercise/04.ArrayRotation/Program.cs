using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine()); //51 47 32 61 21
            int curentNumber = 0;
            for (int i = 0; i < number; i++)
            {
                curentNumber = array[0];
                for (int r = 0; r < array.Length-1; r++)
                {
                    array[r] = array[r + 1];
                }
                array[array.Length - 1] = curentNumber;
            }

            Console.WriteLine(string.Join(" ",array));

        }
    }
}

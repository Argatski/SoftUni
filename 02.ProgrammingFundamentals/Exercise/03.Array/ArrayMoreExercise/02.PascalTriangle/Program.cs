using System;
using System.Collections.Generic;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] previousRow;
            int[] currentRow = { 1 };
            previousRow = currentRow;

            for (int col = 1; col <= number; col++)
            {
                currentRow = new int[col];
                currentRow[0] = 1;
                currentRow[col - 1] = 1;

                for (int row = 0; row <= col - 3; row++)
                {
                    currentRow[row + 1] = previousRow[row] + previousRow[row + 1];
                }

                foreach (var item in currentRow)
                {
                    Console.Write(item + " ");

                }
                Console.WriteLine();
                previousRow = currentRow;
            }
        }
    }
}

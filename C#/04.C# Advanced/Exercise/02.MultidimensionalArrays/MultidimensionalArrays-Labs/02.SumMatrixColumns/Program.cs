using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            //Processing
            CreatedMatrix(matrix);

            //Print
            PrintResult(matrix);

        }

        static void PrintResult(int[,] matrix)
        {

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                int sum = 0;

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, cols];
                }
                Console.WriteLine(sum);
            }

        }

        static void CreatedMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = array[cols];
                }
            }
        }
    }
}

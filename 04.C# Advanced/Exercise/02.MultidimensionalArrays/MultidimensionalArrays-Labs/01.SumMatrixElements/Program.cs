using System;
using System.Linq;

namespace _01.SumMatrixElements
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

            PrintResult(matrix);

        }

        private static void PrintResult(int[,] matrix)
        {
            //Print Columns
            Console.WriteLine(matrix.GetLength(0));

            //Print Rows
            Console.WriteLine(matrix.GetLength(1));

            //Print Sum
            int sum = 0;

            foreach (int arr in matrix)
            {
                sum += arr;
            }

            Console.WriteLine(sum);
        }

        static void CreatedMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = currentArray[cols];
                }

            }
        }
    }
}

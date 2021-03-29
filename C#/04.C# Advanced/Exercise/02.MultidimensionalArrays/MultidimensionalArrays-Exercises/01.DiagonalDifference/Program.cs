using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            //Filling matrix whit numbers
            CreateMatrix(matrix);

            //Diagonal sum
            SumDiagonal(matrix);

        }
        /// <summary>
        /// Difference diagonal sum
        /// </summary>
        /// <param name="matrix"></param>
        private static void SumDiagonal(int[,] matrix)
        {
            int primaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col <=row; col++)
                {
                    primaryDiagonal += matrix[row, col];
                }
            }

            int secondaryDiagonal = 0;

            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(0)- row-1; col >= matrix.GetLength(0) - row - 1; col--)
                {
                    secondaryDiagonal += matrix[row, col];
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }

        /// <summary>
        /// Create matrix using "for cycle" and array.
        /// </summary>
        /// <param name="matrix"></param>
        static void CreateMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] array = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = array[col];
                }
            }
        }
    }
}

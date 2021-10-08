using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            //Input 
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            //Solution
            CreateMatrix(matrix);

            SumDiagonal(matrix);

        }

        /// <summary>
        /// Create matrix using "for cycle" and array.
        /// </summary>
        /// <param name="matrix"></param>
        static void SumDiagonal(int[,] matrix)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = rows; cols <= rows; cols++)
                {
                    leftSum += matrix[rows, cols];
                }

            }

            for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
            {
                for (int cols = matrix.GetLength(0) - rows - 1; cols >= matrix.GetLength(0) - rows - 1; cols--)
                {
                    rightSum += matrix[rows, cols];
                }
            }

            Console.WriteLine(Math.Abs(leftSum-rightSum));
        }

        /// <summary>
        /// Create matrix with size "n"
        /// </summary>
        /// <param name="matrix"></param>
        static void CreateMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < arr.Length; cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }
        }
    }
}



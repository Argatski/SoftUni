using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            //Input
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            //Create matrix
            char[,] matrix = new char[rows, cols];
            CreateMatrix(matrix);

            //Find the count of 2 x 2 squares of equal chars in a matrix.
            FindSquares(matrix);

        }

        /// <summary>
        /// Find the count of 2 x 2 squares of equal chars in a matrix.
        /// </summary>
        /// <param name="matrix"></param>
        static void FindSquares(char[,] matrix)
        {
            int n = 2;

            int count = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - n + 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - n + 1; cols++)
                {
                    bool isValid = matrix[rows, cols] == matrix[rows, cols + 1] && matrix[rows, cols] == matrix[rows + 1, cols] && matrix[rows, cols] == matrix[rows + 1, cols + 1];

                    if (isValid)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        /// <summary>
        /// Create  char matrix of size
        /// </summary>
        /// <param name="matrix"></param>
        static void CreateMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int cols = 0; cols < arr.Length; cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }

        }
    }
}


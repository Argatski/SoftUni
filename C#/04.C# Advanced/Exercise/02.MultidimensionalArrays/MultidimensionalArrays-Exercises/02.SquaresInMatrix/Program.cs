using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = size[0];
            int col = size[1];

            char[,] matrix = new char[row, col];

            //Create matrix
            CreateMatrix(matrix);

            //Cheked squares in matrix
            FindSquares(matrix);
        }

        static void FindSquares(char[,] matrix)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - n + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - n + 1; col++)
                {


                    bool isValid = matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row, col]
                        && matrix[row + 1, col + 1] == matrix[row, col];
                    if (isValid)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        static void CreateMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = array[col];
                }
            }
        }
    }
}

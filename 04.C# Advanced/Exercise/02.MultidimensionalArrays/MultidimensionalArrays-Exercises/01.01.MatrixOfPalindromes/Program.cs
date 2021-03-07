using System;
using System.Linq;

namespace _01._01.MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            //Created matrix
            CreatedMatrix(matrix);

            //Print result
            PrintMatrix(matrix);

        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void CreatedMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char symbol = Convert.ToChar('a' + row);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char middleSymbol = Convert.ToChar(symbol + col);
                    
                    matrix[row, col] = symbol.ToString() + middleSymbol + symbol;
                }
            }
        }
    }
}

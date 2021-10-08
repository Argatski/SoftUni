using System;
using System.Linq;

namespace _01._01.MatrixOfPalindromes
{
    class MatrixPalindromes
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

            //Create matrix of palindromes
            CreateMatrix(matrix);

            //Print matrix of palindromes
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows,cols]+" ");
                }
                Console.WriteLine();
            }
        }

        static void CreateMatrix(string[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char symbol = Convert.ToChar('a' + rows);

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    char middleSymbol =Convert.ToChar(symbol + cols);
                    matrix[rows, cols] = (symbol).ToString() + middleSymbol + symbol; 
                }
            }
        }
    }
}

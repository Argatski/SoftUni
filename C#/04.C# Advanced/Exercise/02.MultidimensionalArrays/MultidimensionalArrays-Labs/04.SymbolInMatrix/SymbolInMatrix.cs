using System;

namespace _04.SymbolInMatrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            //Read size
            int size = int.Parse(Console.ReadLine());

            //Solution
            char[,] matrix = new char[size, size];

            //Create matrix
            CreateMatrix(matrix);

            //Find and print
            FindAndPrint(matrix);
        }

        private static void FindAndPrint(char[,] matrix)
        {
            //Find the first occurrence of that symbol in the matrix
            char symbol = char.Parse(Console.ReadLine());

            int row = -1;
            int col = -1;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (symbol == matrix[rows, cols])
                    {
                        row = rows;
                        col = cols;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if (row == -1 || col == -1)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }

        static void CreateMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string input = Console.ReadLine();

                for (int cols = 0; cols < input.Length; cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }
        }
    }
}


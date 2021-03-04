using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            //Processing
            CreatedMatrix(matrix);

            //Print result
            FindAndPrint(matrix);
        }

        static void FindAndPrint(char[,] matrix)
        {
            char symbol = char.Parse(Console.ReadLine());

            int rowIndex = -1;
            int colIndex = -1;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    char current = matrix[rows, cols];

                    if (symbol == matrix[rows, cols])
                    {
                        rowIndex = rows;
                        colIndex = cols;

                        Console.WriteLine($"({rowIndex}, {colIndex})");
                        return;
                    }

                }

            }

            if (rowIndex == -1 || colIndex == -1)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }

        static void CreatedMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string text = Console.ReadLine();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = text[cols];
                }
            }

        }
    }
}

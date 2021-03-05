using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            //Create matrix
            CreateMatrix(matrix);

            GetMaximumSumAndPrint(matrix);
        }

        static void GetMaximumSumAndPrint(int[,] matrix)
        {
            int sum = int.MinValue;
            int startRows = 0;
            int startColumns = 0;

            // if you want dynamic matrix read "n" from the console
            int n = 2;

            for (int row = 0; row < matrix.GetLength(0) - n + 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - n + 1; column++)
                {
                    //If n = 2;
                    /*int currentSum = matrix[rows, columns] + matrix[rows + 1, columns] +
                        matrix[rows, columns + 1] + matrix[rows + 1, columns + 1];*/

                    int currentSum = 0;

                    //Use this nested for if you want a dynamic Sum matrix 
                    for (int squereRow = row; squereRow < row + n; squereRow++)
                    {
                        for (int col = column; col < column + n; col++)
                        {
                            currentSum += matrix[squereRow, col];
                        }
                    }
                    //
                    if (sum < currentSum)
                    {
                        startRows = row;
                        startColumns = column;
                        sum = currentSum;
                    }
                }
            }


            for (int row = startRows; row < startRows + n; row++)
            {
                for (int column = startColumns; column < startColumns + n; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }

        static void CreateMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] array = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = array[columns];
                }
            }
        }
    }
}

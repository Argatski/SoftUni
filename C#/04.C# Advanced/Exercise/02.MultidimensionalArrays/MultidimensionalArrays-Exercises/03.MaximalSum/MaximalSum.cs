using System;
using System.Linq;

namespace _03.MaximalSum
{
    class MaximalSum
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

            //Processing
            int[,] matrix = new int[rows, cols];

            CreateMatrix(matrix);

            int[] result = FindMaximalSum(matrix);

            //Print result
            Print(result, matrix);
        }

        static void Print(int[] result, int[,] matrix)
        {
            int startRow = result[0];
            int startCols = result[1];
            int num = result[3];

            Console.WriteLine($"Sum = {result[2]}");

            for (int rows = startRow; rows < startRow + num; rows++)
            {
                for (int cols = startCols; cols < startCols + num; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] FindMaximalSum(int[,] matrix)
        {
            int sum = int.MinValue;
            int num = 3; //Work whit different input read from the console 
            int startRow = 0;
            int startCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - num + 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - num + 1; cols++)
                {
                    int currentSum = 0;

                    for (int squaresRows = rows; squaresRows < rows + num; squaresRows++)
                    {
                        for (int squaresCols = cols; squaresCols < cols + num; squaresCols++)
                        {
                            currentSum += matrix[squaresRows, squaresCols];
                        }
                    }

                    if (currentSum > sum)
                    {
                        startRow = rows;
                        startCol = cols;
                        sum = currentSum;
                    }
                    currentSum = 0;
                }
            }

            int[] result = new int[4];

            result[0] = startRow;
            result[1] = startCol;
            result[2] = sum;
            result[3] = num;

            return result;
        }

        /// <summary>
        /// Create matrix of size NxM
        /// </summary>
        /// <param name="matrix"></param>
        static void CreateMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
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


//Another solution
/*
  /// <summary>
        /// Find maximal sum 
        /// </summary>
        /// <param name="matrix"></param>
        static void FindMaximalSum(int[,] matrix)
        {
            int sum = int.MinValue;
            int sizeSqiare = 3; //Work whit different input read from the console 

            int startRow = 0;
            int StartCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - sizeSqiare + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - sizeSqiare + 1; col++)
                {

                    int currentSum = 0;

                    for (int suareRow = row; suareRow < row + sizeSqiare; suareRow++)
                    {
                        for (int columns = col; columns < col + sizeSqiare; columns++)
                        {
                            currentSum += matrix[suareRow, columns];
                        }
                    }

                    if (sum < currentSum)
                    {
                        startRow = row;
                        StartCol = col;
                        sum = currentSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            for (int row = startRow; row < startRow + sizeSqiare; row++)
            {
                for (int col = StartCol; col < StartCol + sizeSqiare; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

 */
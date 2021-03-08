using System;
using System.Linq;

namespace _03.MaximalSum
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

            //Processing
            int[,] matrix = new int[size[0], size[1]];

            CreateMatrix(matrix);

            FindMaximalSum(matrix);
        }

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
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }

        static void CreateMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //Input array 
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

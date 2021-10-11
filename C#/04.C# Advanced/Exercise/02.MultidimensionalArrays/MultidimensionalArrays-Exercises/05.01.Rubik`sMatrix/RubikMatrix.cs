using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._01.Rubik_sMatrix
{
    class RubikMatrix
    {
        static void Main(string[] args)
        {
            //Input
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int columns = size[1];

            int[,] matrix = new int[rows, columns];

            //Processing
            CreatedMatrix(matrix);

            ShufflingMatrix(matrix);

            RearrangeMatrix(matrix);

            //Print
            //PrintiMatrix(matrix);
        }

        static void RearrangeMatrix(int[,] matrix)
        {
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentNumber = matrix[row, col];
                    counter++;
                    if (currentNumber == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        int currentRow = -1;
                        int currentCol = -1;
                        for (int r = row; r < matrix.GetLength(0); r++)
                        {
                            currentRow = r;
                            for (int c = 0; c < matrix.GetLength(1); c++)
                            {
                                int number = matrix[r, c];

                                if (counter == number)
                                {
                                    currentCol = c;
                                    matrix[row, col] = number;
                                    matrix[r, c] = currentNumber;
                                    Console.WriteLine($"Swap ({row}, {col}) with ({currentRow}, {currentCol})");
                                    continue;
                                }
                            }
                        }

                    }
                }
            }
        }

        static void ShufflingMatrix(int[,] matrix)
        {
            int numberCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommands; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (commands[1])
                {
                    case "up":
                        MoveToUp(matrix, commands);
                        break;
                    case "down":
                        MoveToDown(matrix, commands);
                        break;
                    case "left":
                        MoveToLeft(matrix, commands);
                        break;
                    case "right":
                        MoveToRight(matrix, commands);
                        break;
                }
            }
        }
        /// <summary>
        /// Move right corresponding row
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="commands"></param>
        private static void MoveToRight(int[,] matrix, string[] commands)
        {
            int rowIndex = int.Parse(commands[0]);
            int repeatCommand = int.Parse(commands[2]);

            for (int r = 0; r < repeatCommand; r++)
            {
                int currentNum = matrix[rowIndex, matrix.GetLength(1) - 1];

                for (int col = matrix.GetLength(1) - 1; col > 0; col--)
                {
                    matrix[rowIndex, col] = matrix[rowIndex, col - 1];
                }
                matrix[rowIndex, 0] = currentNum;

            }

        }
        /// <summary>
        /// Move left corresponding row
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="commands"></param>
        static void MoveToLeft(int[,] matrix, string[] commands)
        {
            int rowIndex = int.Parse(commands[0]);
            int repeatCommand = int.Parse(commands[2]);

            for (int r = 0; r < repeatCommand; r++)
            {
                int currentNum = matrix[rowIndex, 0];
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    matrix[rowIndex, col] = matrix[rowIndex, col + 1];
                }
                matrix[rowIndex, matrix.GetLength(1) - 1] = currentNum;
            }
        }
        /// <summary>
        /// Move Down corresponding column
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="commands"></param>
        private static void MoveToDown(int[,] matrix, string[] commands)
        {
            int indexCol = int.Parse(commands[0]);
            int repeatCommand = int.Parse(commands[2]);

            for (int r = 0; r < repeatCommand; r++)
            {
                int currentNum = matrix[matrix.GetLength(0) - 1, indexCol];
                for (int row = matrix.GetLength(0) - 1; row > 0; row--)
                {
                    matrix[row, indexCol] = matrix[row - 1, indexCol];
                }
                matrix[0, indexCol] = currentNum;
            }

        }
        /// <summary>
        /// Move up corresponding column
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="commands"></param>
        static void MoveToUp(int[,] matrix, string[] commands)
        {
            int indexCol = int.Parse(commands[0]);
            int repeatCommand = int.Parse(commands[2]);

            for (int r = 0; r < repeatCommand; r++)
            {
                int currentNum = matrix[0, indexCol];
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    matrix[row, indexCol] = matrix[row + 1, indexCol];
                }
                matrix[matrix.GetLength(0) - 1, indexCol] = currentNum;
            }

        }

        /// <summary>
        /// Print current matrix
        /// </summary>
        /// <param name="matrix"></param>
        /*static void PrintiMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }*/

        static void CreatedMatrix(int[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    count++;
                    matrix[row, col] = count; // TODO: Load
                }
            }
        }
    }
}
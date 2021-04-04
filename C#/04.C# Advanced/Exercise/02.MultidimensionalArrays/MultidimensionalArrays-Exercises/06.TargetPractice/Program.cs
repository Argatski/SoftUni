using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             The input data will always be valid
             and int the format described.There is no needto check it.
            */
            //Input is an array with parameters of matrix row and col
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Strings represent the name of the snake and its length
            string snake = Console.ReadLine();
            char[,] matrix = new char[size[0], size[1]];

            /*//Create a matrix with size
            Queue<char> queue = new Queue<char>(snake);
            CreatorMatrix(queue, matrix);*/

            //Another way to create a matrix/
            int counter = 0;
            bool goesLeft = true;

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                int j = goesLeft ? matrix.GetLength(1) - 1 : 0;
                for (; j >= 0 && j < matrix.GetLength(1); j = goesLeft ? j - 1 : j + 1)
                {
                    matrix[i, j] = snake[counter++ % snake.Length];
                }

                goesLeft = !goesLeft;
            }


            //Read shot parameters.
            int[] parameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Processing
            ShotSnake(matrix, parameters);

            ReplaceAllCharacters(matrix);

            //Print
            Print(matrix);

        }
        /// <summary>
        /// Replace all characters in the blast area with a space
        /// </summary>
        /// <param name="matrix"></param>
        static void ReplaceAllCharacters(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int r = matrix.GetLength(0) - 1; r > 0; r--)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[r, col] == ' ')
                        {
                            char temp = matrix[r, col];
                            matrix[r, col] = matrix[r - 1, col];
                            matrix[r - 1, col] = temp;

                        }
                    }
                }

            }
        }

        static void ShotSnake(char[,] matrix, int[] parameters)
        {
            int impactRow = parameters[0];
            int impactColumn = parameters[1];
            int radius = parameters[2];

            for (int row = impactRow - radius; row <= impactRow + radius; row++)
            {
                for (int col = impactColumn - radius; col <= impactColumn + radius; col++)
                {
                    /*
                     Coordinates are valid but maybe projectile land is out of range.
                     */
                    if (IsInRange(row, col, impactRow, impactColumn, radius, matrix))
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        static bool IsInRange(int row, int col, int impactRow, int impactColumn, int radius, char[,] matrix)
        {
            if (row < 0 || row >= matrix.GetLength(0) ||
                col < 0 || col >=matrix.GetLength(1))
            {
                return false;
            }
            if (Math.Sqrt(Math.Pow(impactRow - row, 2) + Math.Pow(impactColumn - col, 2)) <= radius)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Printing matrix values
        /// </summary>
        /// <param name="matrix"></param>
        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// This method creates a size matrix read by the console and enters a character from the queue as a value
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="matrix"></param>
        static void CreatorMatrix(Queue<char> queue, char[,] matrix)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (row % 2 == 0)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        char currentSymbol = queue.Dequeue();
                        matrix[row, col] = currentSymbol;
                        queue.Enqueue(currentSymbol);
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentSymbol = queue.Dequeue();
                        matrix[row, col] = currentSymbol;
                        queue.Enqueue(currentSymbol);
                    }
                }

            }
        }
    }
}

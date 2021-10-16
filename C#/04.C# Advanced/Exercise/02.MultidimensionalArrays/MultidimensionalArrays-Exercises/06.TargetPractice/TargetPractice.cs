using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            /*
            The input data will always be valid
            and int the format described.There is no needto check it.
           */
            //Input is an array with parameteres of matrix row and col
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //Strings represent the name of the snake and its length
            string snake = Console.ReadLine();
            char[,] matrix = new char[size[0], size[1]];

            //Create a matrix with size 
            /* Queue<char> queue = new Queue<char>(snake);
            CreatorMatrix(queue, matrix);*/

            //Another way to crete a matrix
            int count = 0;
            bool goesLeft = true;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                int col = goesLeft ? matrix.GetLength(1) - 1 : 0;

                for (; col >= 0 && col < matrix.GetLength(1); col = goesLeft ? col - 1 : col + 1)
                {
                    matrix[row, col] = snake[count++ % snake.Length];
                }
                goesLeft = !goesLeft;
            }

            //Read shot parameters.
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //Processing
            ShotSnake(matrix, parameters);

            ReplaceAllWhitespace(matrix);

            //Print
            Print(matrix);


        }
        /// <summary>
        /// Print result matrix
        /// </summary>
        /// <param name="matrix"></param>
        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Replace all whitespace in the blast area whit character
        /// </summary>
        /// <param name="matrix"></param>
        private static void ReplaceAllWhitespace(char[,] matrix)
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

        /// <summary>
        /// Shot
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="parameters"></param>
        static void ShotSnake(char[,] matrix, int[] parameters)
        {
            int impactRow = parameters[0];
            int impactCol = parameters[1];
            int radius = parameters[2];

            for (int row = impactRow - radius; row <= impactRow + radius; row++)
            {
                for (int col = impactCol - radius; col <= impactCol + radius; col++)
                {
                    //Coordinates are valid but maybe projectile land is out of range.

                    if (isInRange(row, col, impactRow, impactCol, radius, matrix))
                    {
                        matrix[row, col] = ' ';
                    }

                }
            }
        }

        /// <summary>
        /// Check the coordinates if they are in the range of the matrix.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="impactRow"></param>
        /// <param name="impactCol"></param>
        /// <param name="radius"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static bool isInRange(int row, int col, int impactRow, int impactCol, int radius, char[,] matrix)
        {
            if (row < 0 || row >= matrix.GetLength(0) ||
                col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }
            if (Math.Sqrt(Math.Pow(impactRow - row, 2) + Math.Pow(impactCol - col, 2)) <= radius)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// This method creates a size matrix read by the console and enteres a character from the queue as a value.
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

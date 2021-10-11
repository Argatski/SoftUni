using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            //Input
            int[] sizeMatrix = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = sizeMatrix[0];
            int col = sizeMatrix[1];

            //Create matrix whit size row and col
            string[,] matrix = new string[row, col];
            CreateMatrix(matrix);

            //Processing
            Procssing(matrix);
        }
        /// <summary>
        /// Swap matrix
        /// </summary>
        /// <param name="matrix"></param>
        static void Procssing(string[,] matrix)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command[0])
                {
                    case "swap":
                        SwapMatrix(command, matrix);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }

        /// <summary>
        /// Swap command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="matrix"></param>
        static void SwapMatrix(string[] command, string[,] matrix)
        {
            if (command.Length != 5)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            //Valid first coordinate "row1"
            int row1 = int.Parse(command[1]);
            bool isValidRow1 = matrix.GetLength(0) >= row1 &&
                row1 >= 0;

            //Valid first coordinate "col1"
            int col1 = int.Parse(command[2]);
            bool isValidCol1 = matrix.GetLength(1) >= col1 &&
                col1 >= 0;

            //Valid second coordinate "row2"
            int row2 = int.Parse(command[3]);
            bool isValidRow2 = matrix.GetLength(0) >= row2 &&
                row2 >= 0;

            //Valid second coordinate "col2"
            int col2 = int.Parse(command[4]);
            bool isValidCol2 = matrix.GetLength(1) >= col2 &&
                col2 >= 0;

            if (isValidCol1 || isValidCol2 || isValidRow1 || isValidRow2)
            {
                string firstNum = matrix[row1, col1];
                string secondNum = matrix[row2, col2];

                matrix[row1, col1] = secondNum;
                matrix[row2, col2] = firstNum;

                //Print current result
                Print(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        /// <summary>
        /// Print result
        /// </summary>
        /// <param name="matrix"></param>
        static void Print(string[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows,cols] +" ");
                }
                Console.WriteLine();
            }
        }

        static void CreateMatrix(string[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < arr.Length; cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }


            }

        }
    }
}


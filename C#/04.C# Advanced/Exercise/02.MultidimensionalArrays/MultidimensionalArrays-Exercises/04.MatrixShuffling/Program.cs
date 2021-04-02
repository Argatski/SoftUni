using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
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

            string[,] matrix = new string[row, col];

            //Created matrix
            CreatedMatrix(matrix);

            //Processing
            Processing(matrix);

            //Print matrix

        }

        static void Print(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Processing(string[,] matrix)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "swap":
                        SwapMatrix(matrix, command);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

        }

        static void SwapMatrix(string[,] matrix, string[] command)
        {
            if (command.Length != 5)
            { 
                Console.WriteLine("Invalid input!");
                return;
            }

            //Valid first coordinates 
            int row1 = int.Parse(command[1]);
            bool validRow1 = matrix.GetLength(0) >= row1 && row1 >= 0;

            int col1 = int.Parse(command[2]);
            bool validCol1 = matrix.GetLength(1) >= col1 && col1 >= 0;

            //Valid second coordinates
            int row2 = int.Parse(command[3]);
            bool validRow2 = matrix.GetLength(0) >= row2 && row2 >= 0;

            int col2 = int.Parse(command[4]);
            bool validCol2 = matrix.GetLength(1) >= col2 && col2 >= 0;


            if (validRow1 == false || validRow2 == false
                || validCol1 == false || validCol2 == false)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                string numberSwap = matrix[row1, col1];
                string numnberChage = matrix[row2, col2];

                matrix[row1, col1] = numnberChage;
                matrix[row2, col2] = numberSwap;

                Print(matrix);
            }

        }

        static void CreatedMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = array[col];
                }

            }
        }
    }
}

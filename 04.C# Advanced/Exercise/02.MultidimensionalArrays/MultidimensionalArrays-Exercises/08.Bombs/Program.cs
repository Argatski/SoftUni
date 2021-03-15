using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            //Create matrix
            CrateMatrix(matrix);

            //Processing matrix
            Processing(matrix);

            //Print result matrix
            PrintResult(matrix);
        }

        static void PrintResult(int[,] matrix)
        {
            //Print alive cells and sum
            int count = 0;
            int sum = 0;
            foreach (int cell in matrix)
            {
                if (cell > 0)
                {
                    count++;
                    sum += cell;
                }
            }



            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            //Print matrix
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }


        }

        static void Processing(int[,] matrix)
        {
            string[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < coordinates.Length; i++)
            {
                string currentCoordinates = coordinates[i];
                int bombRow = int.Parse(currentCoordinates[0].ToString());
                int bombCol = int.Parse(currentCoordinates[2].ToString());

                int bombValue = matrix[bombRow, bombCol];


                for (int k = bombRow - 1; k <= bombRow + 1; k++)
                {
                    for (int j = bombCol - 1; j <= bombCol + 1; j++)
                    {
                        if (j >= 0 && j < matrix.GetLength(1)
                          && k >= 0 && k < matrix.GetLength(0))
                        {
                            if (matrix[k, j] <= 0 || bombValue < 0)
                            {
                                continue;
                            }

                            matrix[k, j] -= bombValue;
                        }
                    }
                }

            }
        }

        static bool isRangeCoordinates(string[] coordinates, int r, int c)
        {
            for (int i = 0; i < coordinates.Length; i++)
            {
                string currentCoordinates = coordinates[i];
                int bombRow = int.Parse(currentCoordinates[0].ToString());
                int bombCol = int.Parse(currentCoordinates[2].ToString());

                if (r == bombRow && c == bombCol)
                {
                    return true;
                }
            }
            return false;
        }

        static void CrateMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = array[c];
                }
            }
        }
    }
}

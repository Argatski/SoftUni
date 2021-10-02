using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            //Input will matrix sizes
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            //Solution
            int row = size[0];
            int col = size[1];

            int[,] matrix = new int[row, col];

            //Create matrix
            CreateMatrix(matrix);

            //Print solution
            Print(matrix);

        }

        private static void Print(int[,] matrix)
        {
            //Print rows
            Console.WriteLine(matrix.GetLength(0));

            //Print cols
            Console.WriteLine(matrix.GetLength(1));

            //Print sum of matrix
            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }

        private static void CreateMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] array = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < array.Length; cols++)
                {
                    matrix[rows, cols] = array[cols];
                }
            }
        }
    }
}



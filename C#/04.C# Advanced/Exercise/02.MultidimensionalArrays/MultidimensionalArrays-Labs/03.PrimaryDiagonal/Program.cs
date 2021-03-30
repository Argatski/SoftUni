using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            //Processing
            CreatedMatrix(matrix);

            //Sum and print result
            SumPrimaryDiagonal(matrix);
        }

        static void SumPrimaryDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (rows == cols)
                    {
                        sum += matrix[rows, cols];
                    }
                }
            }

            Console.WriteLine(sum);
        }

        static void CreatedMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = array[cols]; //[0,0] [0,1] [0,2]...
                }
            }
        }
    }
}

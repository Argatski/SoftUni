using System;
using System.Linq;
class PrimaryDiagonal
{
    static void Main(string[] args)
    {
        //Input
        int size = int.Parse(Console.ReadLine());

        //Solution
        int[,] matrix = new int[size, size];

        //Create matrix
        CreateMatrix(matrix);

        //Sum and print result
        Print(matrix);
    }

    static void Print(int[,] matrix)
    {
        int sum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = rows; cols <= rows; cols++)
            {
                sum += matrix[rows, cols];
            }

            //Another solution
            /*
             for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (rows == cols)
                    {
                        sum += matrix[rows, cols];
                    }
                }
             */
        }
        Console.WriteLine(sum);
    }

    static void CreateMatrix(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int cols = 0; cols < array.Length; cols++)
            {
                matrix[rows, cols] = array[cols];
            }
        }
    }
}

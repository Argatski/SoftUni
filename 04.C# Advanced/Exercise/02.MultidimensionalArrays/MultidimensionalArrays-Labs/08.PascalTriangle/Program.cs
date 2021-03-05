using System;

namespace _08.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            long[][] triangle = new long[number][];

            //Create pascal triangle
            CreateTriangle(triangle);

            //Print pascla triangle
            PrintPascalTriangle(triangle);
        }

        static void PrintPascalTriangle(long[][] triangle)
        {
            foreach (long[] item in triangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        static void CreateTriangle(long[][] triangle)
        {
            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    long sum = 0;
                    if (row - 1 >= 0 && col < triangle[row - 1].Length)
                    {
                        sum += triangle[row - 1][col];
                    }
                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        sum += triangle[row - 1][col - 1];
                    }
                    if (sum==0)
                    {
                        sum = 1;
                    }
                    triangle[row][col] = sum;
                }
            }
        }
    }
}

using System;
using System.Linq;

namespace _07._01.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());

            int[,] spiralMatrix = new int[n, n];

            //Create spiral matrix
            CreateSpiralMatrix(spiralMatrix, n);

            //Print spiral matrix
            PrintSpiralMatrix(spiralMatrix);
        }

        static void PrintSpiralMatrix(int[,] spiralMatrix)
        {
            for (int r = 0; r < spiralMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < spiralMatrix.GetLength(1); c++)
                {
                    if (spiralMatrix[r,c]<10)
                    {
                        Console.Write(" "+spiralMatrix[r, c] + " ");
                    }
                    else 
                    {
                        Console.Write(spiralMatrix[r, c] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static bool isRange(int[,]matrix,int r,int c,int s)
        {
            return r >= 0 && c >= 0 && r < s && c < s && matrix[r, c] != 0;
        }
        static void CreateSpiralMatrix(int[,] spiralMatrix, int size)
        {
            string direction = "right";
            int row = 0;
            int col = 0;
            for (int i = 0; i < size * size; i++)
            {
                spiralMatrix[row, col] = i+1;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }


                if ((col == size || isRange(spiralMatrix,row,col,size)) && direction == "right")
                {
                    row++;
                    col--;
                    direction = "down";
                }
                if ((row == size || isRange(spiralMatrix,row,col,size)) && direction == "down")
                {
                    row--;
                    col--;
                    direction = "left";
                }
                if ((col == -1 || isRange(spiralMatrix, row, col, size)) && direction == "left")
                {
                    row--;
                    col++;
                    direction = "up";
                }
                if ((row == -1 || isRange(spiralMatrix, row, col, size)) && direction == "up")
                {
                    row++;
                    col++;
                    direction = "right";
                }
            }
        }
    }
}

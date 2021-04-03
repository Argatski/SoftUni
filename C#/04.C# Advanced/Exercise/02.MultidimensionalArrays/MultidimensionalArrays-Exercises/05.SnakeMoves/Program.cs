using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            char[,] matrixIsle = new char[size[0], size[1]];

            //Ceated way of snake
            CreatWayOfSanke(snake, matrixIsle);

            //Print matrix 
            PrintMatrix(matrixIsle);

        }

        static void PrintMatrix(char[,] matrixIsle)
        {
            for (int row = 0; row < matrixIsle.GetLongLength(0); row++)
            {
                for (int col = 0; col < matrixIsle.GetLongLength(1); col++)
                {
                    Console.Write(matrixIsle[row,col]);
                }
                Console.WriteLine();
            }
        }

        static void CreatWayOfSanke(string snake, char[,] matrixIsle)
        {
            //Use queue because the symbol of the word should repeat.
            Queue<char> text = new Queue<char>(snake);

            for (int row = 0; row < matrixIsle.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrixIsle.GetLength(1); col++)
                    {
                        char currentSymbol = text.Dequeue();
                        text.Enqueue(currentSymbol);
                        matrixIsle[row, col] = currentSymbol;
                    }

                }
                if (row % 2 != 0)
                {
                    for (int col = matrixIsle.GetLength(1)-1; col >= 0; col--)
                    {
                        char currentSymbol = text.Dequeue();
                        text.Enqueue(currentSymbol);
                        matrixIsle[row, col] = currentSymbol;
                    }
                }

            }

        }
    }
}

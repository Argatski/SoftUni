using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int size = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine().ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] field = new char[size, size];

            int startRow = 0;
            int startCol = 0;

            for (int r = 0; r < size; r++)
            {
                char[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int c = 0; c < size; c++)
                {
                    field[r, c] = array[c];

                    if (field[r, c] == 's')
                    {
                        startRow = r;
                        startCol = c;
                    }
                }

            }
            //Processing
            Processing(field, startRow, startCol, commands);
        }

        static void Processing(char[,] field, int row, int col, string[] commands)
        {

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "left":
                        if (col - 1 >= 0)
                        {
                            if (field[row, col - 1] == 'c')
                            {
                                field[row, col - 1] = '*';
                            }
                            else if (field[row, col - 1] == 'e')
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                                //Environment.Exit(0);
                            }
                            col--;
                        }
                        break;
                    case "right":
                        if (col + 1 < field.GetLength(1))
                        {
                            if (field[row, col + 1] == 'c')
                            {
                                field[row, col + 1] = '*';
                            }
                            else if (field[row, col + 1] == 'e')
                            {
                                col++;
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                                //Environment.Exit(0);
                            }
                            col++;
                        }
                        break;
                    case "up":
                        if (row - 1 >= 0)
                        {
                            if (field[row - 1, col] == 'c')
                            {
                                field[row - 1, col] = '*';
                            }
                            else if (field[row - 1, col] == 'e')
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                                //Environment.Exit(0);
                            }
                            row--;
                        }
                        break;

                    case "down":
                        if (row + 1 < field.GetLength(0))
                        {
                            if (field[row + 1, col] == 'c')
                            {
                                field[row + 1, col] = '*';
                            }
                            else if (field[row + 1, col] == 'e')
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                                //Environment.Exit(0);
                            }
                            row++;
                        }
                        break;
                }

            }

            //If there are no more commands and none of the above cases
            //had happened, you have to print the following message: 
            int countCoalsLeft = field.Cast<char>().Count(symbol => symbol == 'c');

            Console.WriteLine(countCoalsLeft == 0
                ? $"You collected all coals! ({row}, {col})"
                : $"{countCoalsLeft} coals left. ({row}, {col})");

        }
    }
}

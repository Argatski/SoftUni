using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TruffleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a forest with given size.
            int sizeMatrix = int.Parse(Console.ReadLine());
            char[,] forest = new char[sizeMatrix, sizeMatrix];//The forest will be a matrix with a square shape.

            CreateForest(forest);

            //Solution
            Solution(forest);

            //Print ends forest.
            PrintMatrix(forest);

        }

        /// <summary>
        /// Print ends forest.
        /// </summary>
        /// <param name="forest"></param>
        private static void PrintMatrix(char[,] forest)
        {
            for (int r = 0; r < forest.GetLength(0); r++)
            {
                for (int c = 0; c < forest.GetLength(1); c++)
                {
                    Console.Write(forest[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// The solution helps to pick up truffles. 
        /// </summary>
        /// <param name="forest"></param>
        private static void Solution(char[,] forest)
        {
            //All types of truffles that Peter has collected.
            List<char> petterTruffles = new List<char>();

            //Truffles eaten by the wild boar.
            int count = 0;

            //Input
            string input;
            while ((input = Console.ReadLine()) != "Stop the hunt")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Collect":
                        CollectTruffles(command, forest, petterTruffles);
                        break;
                    case "Wild_Boar":
                        count = CollectTrufflesWildBoar(command, forest, count);
                        break;
                }

            }

            //Print peter manages
            Print(petterTruffles);

            Console.WriteLine($"The wild boar has eaten {count} truffles.");

        }

        /// <summary>
        /// Wild boar eats all truffles in the given cell, skips the next, and eats the next one.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="forest"></param>
        /// <param name="count"></param>
        private static int CollectTrufflesWildBoar(string[] command, char[,] forest, int count)
        {
            //Input
            int startRow = int.Parse(command[1]);
            int startCol = int.Parse(command[2]);
            string direction = command[3];

            //Processing
            switch (direction)
            {
                case "up":
                    count = UpMove(startRow, startCol, forest, count);
                    break;
                case "down":
                    count = DownMove(startRow, startCol, forest, count);
                    break;
                case "left":
                    count = LeftMove(startRow, startCol, forest, count);
                    break;
                case "right":
                    count = RightMove(startRow, startCol, forest, count);
                    break;

            }
            return count;
        }

        /// <summary>
        ///  We move the wild boar right and eat all the truffles in that direction.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="forest"></param>
        /// <param name="count"></param>
        private static int LeftMove(int row, int col, char[,] forest, int count)
        {
            for (int c = col; c >= 0; c -= 2)
            {
                char currentSymbol = forest[row, c];

                if (HaveTruffles(currentSymbol))
                {
                    count++;
                    forest[row, c] = '-';
                }

            }
            return count;
        }

        /// <summary>
        ///  We move the wild boar right and eat all the truffles in that direction.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="forest"></param>
        /// <param name="count"></param>
        private static int RightMove(int row, int col, char[,] forest, int count)
        {
            for (int c = col; c < forest.GetLength(0); c += 2)
            {
                char currentSymbol = forest[row, c];

                if (HaveTruffles(currentSymbol))
                {
                    count++;
                    forest[row, c] = '-';
                }
            }
            return count;
        }

        /// <summary>
        /// We move the wild boar down and eat all the truffles in that direction.
        /// </summary>
        private static int DownMove(int row, int col, char[,] forest, int count)
        {
            for (int r = row; r < forest.GetLength(1); r += 2)
            {
                char currentSymbol = forest[r, col];

                if (HaveTruffles(currentSymbol))
                {
                    count++;
                    forest[r, col] = '-';
                }
            }
            return count;
        }
        /// <summary>
        /// We move the wild boar up and eat all the truffles in that direction.
        /// </summary>
        private static int UpMove(int row, int col, char[,] forest, int count)
        {

            for (int r = row; r >= 0; r -= 2)
            {
                char currentSymbol = forest[r, col];

                if (HaveTruffles(currentSymbol))
                {
                    count++;
                    forest[r, col] = '-';
                }

            }
            return count;
        }

        /// <summary>
        /// Goes to the given place in the forest and collect the truffle if it exists.
        /// </summary>
        /// <param name="command"></param>
        private static void CollectTruffles(string[] command, char[,] forest, List<char> truffles)
        {
            int currentRow = int.Parse(command[1]);
            int currentCol = int.Parse(command[2]);

            char currentSymbol = forest[currentRow, currentCol];

            //bool haveTruffles = currentSymbol == 'B' && currentSymbol == 'S' && currentSymbol == 'W';
            bool isHave = HaveTruffles(currentSymbol);

            if (isHave)
            {
                truffles.Add(currentSymbol);
                forest[currentRow, currentCol] = '-';
            }
        }

        //If you have truffles in the current cell.
        private static bool HaveTruffles(char currentSymbol)
        {
            if (currentSymbol == 'B' | currentSymbol == 'S' | currentSymbol == 'W')
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Print the current matrix.
        /// </summary>
        /// <param name="forest"></param>
        private static void Print(List<char> truffles)
        {
            int countBlackTruffles = truffles.Count(x => x == 'B');
            int countSummerTruffles = truffles.Count(x => x == 'S');
            int countWhiteTruffles = truffles.Count(x => x == 'W');

            Console.WriteLine($"Peter manages to harvest {countBlackTruffles} black, {countSummerTruffles} summer, and {countWhiteTruffles} white truffles.");
        }


        /// <summary>
        /// Create a forest with the given input.
        /// </summary>
        /// <param name="forest"></param>
        public static void CreateForest(char[,] forest)
        {
            /*Input in matrix
             * Black truffle - "B"
             * Summer truffle - "S"
             * White truffle - "W"
             * Empty positions - "-"(Dash)
            */

            for (int r = 0; r < forest.GetLength(0); r++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int c = 0; c < forest.GetLength(1); c++)
                {
                    forest[r, c] = input[c];
                }
            }
        }
    }
}

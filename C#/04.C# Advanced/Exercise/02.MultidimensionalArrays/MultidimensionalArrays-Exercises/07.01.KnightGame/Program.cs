using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            char[,] board = new char[rows, cols];

            for (int row = 0; row < rows; row++) // read the board
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = currentRow[col];
                }
            }

            int numberRemovedKnights = 0;
            while (true) // check the board for knight with maxNumber attack knights
            {
                int maxNumberAttackKnights = int.MinValue;
                int rowMax = int.MinValue;
                int colMax = int.MinValue;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int numberAttackKnights = 0;
                        if (board[row, col] == 'K')
                        {
                            numberAttackKnights = MethodToCheckInFrontOfTheKnight(cols, board, row, col, numberAttackKnights);
                            numberAttackKnights = MethodToCheckBehindTheKnight(rows, cols, board, row, col, numberAttackKnights);
                            numberAttackKnights = MethodToCheckOnLeftTheKnight(rows, board, row, col, numberAttackKnights);
                            numberAttackKnights = MethodToCheckOnRightTheKnight(rows, cols, board, row, col, numberAttackKnights);
                        }

                        if (numberAttackKnights > maxNumberAttackKnights)
                        {
                            maxNumberAttackKnights = numberAttackKnights;
                            rowMax = row;
                            colMax = col;
                        }
                    }
                }

                if (maxNumberAttackKnights > 0)
                {
                    board[rowMax, colMax] = '0';
                    numberRemovedKnights++;
                }

                else if (maxNumberAttackKnights == 0)
                {
                    break;
                }
            }

            Console.WriteLine(numberRemovedKnights);
        }


        private static int MethodToCheckOnRightTheKnight(int rows, int cols, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row + 1 < rows && col + 2 < cols)
            {
                if (board[row + 1, col + 2] == 'K') // on right 
                {
                    numberAttackKnights++;
                }
            }

            if (row - 1 >= 0 && col + 2 < cols)
            {
                if (board[row - 1, col + 2] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }

        private static int MethodToCheckOnLeftTheKnight(int rows, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row + 1 < rows && col - 2 >= 0)
            {
                if (board[row + 1, col - 2] == 'K') // on left 
                {
                    numberAttackKnights++;
                }
            }

            if (row - 1 >= 0 && col - 2 >= 0)
            {
                if (board[row - 1, col - 2] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }

        private static int MethodToCheckBehindTheKnight(int rows, int cols, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row + 2 < rows && col + 1 < cols)
            {
                if (board[row + 2, col + 1] == 'K') // behind
                {
                    numberAttackKnights++;
                }
            }

            if (row + 2 < rows && col - 1 >= 0)
            {
                if (board[row + 2, col - 1] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }

        private static int MethodToCheckInFrontOfTheKnight(int cols, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row - 2 >= 0 && col + 1 < cols)
            {
                if (board[row - 2, col + 1] == 'K') // in front of
                {
                    numberAttackKnights++;
                }
            }

            if (row - 2 >= 0 && col - 1 >= 0)
            {
                if (board[row - 2, col - 1] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }
    }
}



/*using System;
using System.Collections.Generic;


namespace CurrentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Tuple<int, int>> kniteMoves = new Queue<Tuple<int, int>>();
            kniteMoves.Enqueue(new Tuple<int, int>(-1, -2));
            kniteMoves.Enqueue(new Tuple<int, int>(+1, -2));
            kniteMoves.Enqueue(new Tuple<int, int>(-2, -1));
            kniteMoves.Enqueue(new Tuple<int, int>(+2, -1));
            kniteMoves.Enqueue(new Tuple<int, int>(-2, +1));
            kniteMoves.Enqueue(new Tuple<int, int>(+2, +1));
            kniteMoves.Enqueue(new Tuple<int, int>(-1, +2));
            kniteMoves.Enqueue(new Tuple<int, int>(+1, +2));

            int boardSize = int.Parse(Console.ReadLine());

            string[,] board = new string[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                char[] curRow = Console.ReadLine().ToCharArray();
                for (int k = 0; k < boardSize; k++)
                {
                    board[i, k] = curRow[k].ToString();
                }

            }

            bool foundHit = true;
            int mostHits = 0;
            int saveMostHits = 0;
            int bestRow = int.MinValue;
            int bestCol = int.MinValue;
            int removedResult = 0;
            while (foundHit == true)
            {

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int k = 0; k < board.GetLength(1); k++)
                    {
                        if (board[i, k] == "K")
                        {
                            for (int j = 1; j <= kniteMoves.Count; j++)
                            {
                                int row = kniteMoves.Peek().Item1;
                                int col = kniteMoves.Peek().Item2;

                                kniteMoves.Enqueue(kniteMoves.Dequeue());
                                try
                                {
                                    if (board[i + row, k + col] == "K")
                                    {
                                        mostHits++;
                                    }

                                }
                                catch (Exception)
                                {

                                    continue;
                                }
                            }

                        }
                        if (mostHits > 0)
                        {
                            foundHit = true;
                        }
                        else
                        {
                            foundHit = false;
                        }
                        if (mostHits > saveMostHits)
                        {
                            bestRow = i;
                            bestCol = k;
                            saveMostHits = mostHits;
                        }
                        mostHits = 0;
                    }
                }

                if (foundHit = true && bestRow != int.MinValue && bestCol != int.MinValue)
                {
                    board[bestRow, bestCol] = "0";
                    removedResult++;
                }
                saveMostHits = 0;
                bestRow = int.MinValue;
                bestCol = int.MinValue;
            }
            Console.WriteLine(removedResult);
        }
    }
}
*/
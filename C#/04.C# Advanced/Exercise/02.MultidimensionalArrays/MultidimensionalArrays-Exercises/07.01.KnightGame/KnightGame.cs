using System;

namespace KnightGame
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            //Input receive the "N" size of the board
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            char[,] board = new char[rows, cols];

            //Create board whit knight
            CreateBoard(board);

            //Processing
            PlayGame(board);
        }

        static void PlayGame(char[,] board)
        {
            int numberRemoveKnights = 0;
            while (true)// check the board for knight with maxNumber attack knights
            {
                int maxNumberAttackKnights = int.MinValue;
                int rowMax = int.MaxValue;
                int colMax = int.MaxValue;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int numberAttackKnights = 0;

                        if (board[row, col] == 'K')
                        {
                            numberAttackKnights = CheckInFrontOfTheKnight(numberAttackKnights, row, col, board);
                            numberAttackKnights = CheckInBehindOfTheKnight(numberAttackKnights, row, col, board);
                            numberAttackKnights = CheckOnLeftOfTheKnight(numberAttackKnights, row, col, board);
                            numberAttackKnights = CheckOnRightOfTheKnight(numberAttackKnights, row, col, board);

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
                    numberRemoveKnights++;
                }
                else if (maxNumberAttackKnights == 0)
                {
                    break;
                }
            }
            Console.WriteLine(numberRemoveKnights);
        }
        /// <summary>
        /// Move knight right of board "L"
        /// </summary>
        /// <param name="numberAttackKnights"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        private static int CheckOnRightOfTheKnight(int numberAttackKnights, int row, int col, char[,] board)
        {
            if (row + 1 < board.GetLength(0) && col + 2 < board.GetLength(0))
            {
                if (board[row + 1, col + 2] == 'K')
                {
                    numberAttackKnights++;
                }
            }
            if (row - 1 >= 0 && col + 2 < board.GetLength(1))
            {
                if (board[row - 1, col + 2] == 'K')
                {
                    numberAttackKnights++;
                }
            }
            return numberAttackKnights;
        }

        /// <summary>
        /// Move knight left "L" (top,botton) 
        /// </summary>
        /// <param name="numberAttackKnights"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        static int CheckOnLeftOfTheKnight(int numberAttackKnights, int row, int col, char[,] board)
        {
            if (row + 1 < board.GetLength(0) && col - 2 >= 0)
            {
                if (board[row + 1, col - 2] == 'K')
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

        /// <summary>
        /// Move knights behind "L" (left,right)
        /// </summary>
        /// <param name="numberAttackKnights"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        private static int CheckInBehindOfTheKnight(int numberAttackKnights, int row, int col, char[,] board)
        {
            if (row + 2 < board.GetLength(0) && col + 1 < board.GetLength(1))
            {
                if (board[row + 2, col + 1] == 'K') //behind
                {
                    numberAttackKnights++;
                }
            }

            if (row + 2 < board.GetLength(0) && col - 1 >= 0)
            {
                if (board[row + 2, col - 1] == 'K')
                {
                    numberAttackKnights++;

                }
            }
            return numberAttackKnights;
        }

        /// <summary>
        /// Move knights front "L" (left,right)
        /// </summary>
        /// <param name="numberAttackKnights"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        static int CheckInFrontOfTheKnight(int numberAttackKnights, int row, int col, char[,] board)
        {
            if (row - 2 >= 0 && col + 1 < board.GetLength(1))
            {
                if (board[row - 2, col + 1] == 'K')//in front of
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

        /// <summary>
        /// Create board
        /// </summary>
        /// <param name="board"></param>
        static void CreateBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = currentRow[col];
                }
            }
        }
    }
}


///Another Solution using by queue
/*using System;
using System.Collections.Generic;


namespace CurrentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Tuple<int, int>> knightMoves = new Queue<Tuple<int, int>>();
            knightMoves.Enqueue(new Tuple<int, int>(-1, -2));
            knightMoves.Enqueue(new Tuple<int, int>(+1, -2));
            knightMoves.Enqueue(new Tuple<int, int>(-2, -1));
            knightMoves.Enqueue(new Tuple<int, int>(+2, -1));
            knightMoves.Enqueue(new Tuple<int, int>(-2, +1));
            knightMoves.Enqueue(new Tuple<int, int>(+2, +1));
            knightMoves.Enqueue(new Tuple<int, int>(-1, +2));
            knightMoves.Enqueue(new Tuple<int, int>(+1, +2));

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
                            for (int j = 1; j <= knightMoves.Count; j++)
                            {
                                int row = knightMoves.Peek().Item1;
                                int col = knightMoves.Peek().Item2;

                                knightMoves.Enqueue(knightMoves.Dequeue());
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
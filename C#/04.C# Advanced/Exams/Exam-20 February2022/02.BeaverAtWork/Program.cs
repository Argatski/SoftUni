using System;
using System.Linq;

namespace _02.BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line – integer n – the size of the pond (field).
            int sizePond = int.Parse(Console.ReadLine());

            char[,] pond = new char[sizePond, sizePond];

            //Create matrix (Pond).
            int[] positionBeaver = CreateMatrix(pond);

            //Start move breaver
            Processing(positionBeaver, pond);

            //Print
            Print(pond);
            Console.WriteLine(string.Join(" ", positionBeaver));
        }

        /// <summary>
        /// Start move Breaver.
        /// </summary>
        /// <param name="positionBeaver"></param>
        /// <param name="pond"></param>
        private static void Processing(int[] positionBeaver, char[,] pond)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "up":
                        MoveUpBreaver(positionBeaver, pond);

                        //Print current result.
                        Print(pond);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void MoveUpBreaver(int[] positionBeaver, char[,] pond)
        {
            int currentRow = positionBeaver[0] - 1;

            if (currentRow >= 0)
            {
                char currentSymbol = pond[currentRow, positionBeaver[1]];
                if (currentSymbol == 'F')
                {
                    positionBeaver[0] = currentRow;

                    BreaverSwimUp(positionBeaver, pond);
                }
                else if (char.IsLower(currentSymbol))
                {
                    pond[positionBeaver[0], positionBeaver[1]] = '-';

                    positionBeaver[0] = currentRow;

                    pond[positionBeaver[0], positionBeaver[1]] = 'B';
                }
            }
        }

        private static void BreaverSwimUp(int[] positionBeaver, char[,] pond)
        {
            //Swim down
            if (positionBeaver[0] == 0)
            {
                //Swim and change all except the last index.
                for (int r = 0; r < pond.GetLength(0) - 2; r++)
                {
                    pond[r, positionBeaver[1]] = '-';
                }
                int rowIndex = pond.GetLength(0) - 1;

                pond[rowIndex, positionBeaver[1]] = 'B';

                //The new position of breaver.
                positionBeaver[0] = rowIndex;

            }
            else
            {
                for (int r = positionBeaver[0] + 1; r >= 1; r--)
                {
                    pond[r, positionBeaver[1]] = '-';
                }

                //Change last position of Breaver.


                //The new position of breaver.
                pond[0, positionBeaver[1]] = 'B';

                positionBeaver[0] = 0;
            }
            /*else if (positionBeaver[0] == pond.GetLength(0) - 1)
            {
                for (int r = pond.GetLength(0) - 1; r >= 0; r--)
                {
                    pond[r, positionBeaver[1]] = '-';
                }

                int rowIndex = 0;

                pond[rowIndex, positionBeaver[1]] = 'B';

                //The last position of breaver.
                positionBeaver[0] = rowIndex;
            }
            */
        }

        private static void Print(char[,] pond)
        {
            for (int r = 0; r < pond.GetLength(0); r++)
            {
                for (int c = 0; c < pond.GetLength(1); c++)
                {
                    Console.Write(pond[r, c]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Create pond (matrix).
        /// </summary>
        /// <param name="pond"></param>
        private static int[] CreateMatrix(char[,] pond)
        {
            int[] position = new int[2];
            for (int r = 0; r < pond.GetLength(0); r++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int c = 0; c < input.Length; c++)
                {
                    if (input[c] == 'B')
                    {
                        position[0] = r;
                        position[1] = c;
                    }
                    pond[r, c] = input[c];
                }
            }
            return position;
        }
    }
}

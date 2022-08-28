using System;
using System.Linq;

namespace _02.WallDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given the integer n – the size of the matrix (wall).
            int n = int.Parse(Console.ReadLine());
            char[,] wall = new char[n, n]; //Matrix

            //Return position of player and wall;
            int[] position = CreateWall(wall);

            //Processing
            int[] result = new int[4];
            Processing(wall, position, result);

            //Print
            Print(wall, result);


        }

        /// <summary>
        /// Print result
        /// On the first line:
        /// If Vanko manages to make all of the holes, print "Vanko managed to make {countOfHoles} hole(s) and he hit only {countOfRods} rod(s)." .
        /// If Vanko gets electrocuted, print "Vanko got electrocuted, but he managed to make {countOfHoles} hole(s)."
        /// If Vanko lands on a position that already has a hole on it, print "The wall is already destroyed at position [row, col]!"
        /// If Vanko hits a rod, print "Vanko hit a rod!".
        /// At the end, print the final state of the matrix(wall) with Vanko's position on it.
        /// </summary>
        /// <param name="wall"></param>
        private static void Print(char[,] wall, int[] result)
        {
            if (result[1] > 0)
            {

                Console.WriteLine($"Vanko got electrocuted, but he managed to make {result[1] + result[2] + 1} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {result[2] + 1} hole(s) and he hit only {result[3]} rod(s).");
            }

            for (int r = 0; r < wall.GetLength(0); r++)
            {
                for (int c = 0; c < wall.GetLength(1); c++)
                {
                    Console.Write(wall[r, c]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Guide him, so that he doesn't hit a cable or a rod. 
        /// </summary>
        /// <param name="wall"></param>
        private static void Processing(char[,] wall, int[] position, int[] result)
        {
            string command = string.Empty;

            int currentRow = int.MinValue;
            int currentCol = int.MinValue;

            int[] newPosition = new int[2];
            bool valid;



            result[0] = 0;//Vanko
            result[1] = 0;//Electrocuted
            result[2] = 0;//Make hole
            result[3] = 0; //Rod


            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "up":
                        currentRow = position[0] - 1;
                        currentCol = position[1];

                        newPosition[0] = currentRow;
                        newPosition[1] = currentCol;

                        valid = isValid(wall, currentRow, currentCol);
                        if (valid == false)
                        {
                        }
                        else if (wall[currentRow, currentCol] == 'C' && valid == true)
                        {
                            wall[position[0], position[1]] = '*';
                            wall[currentRow, currentCol] = 'E';

                            result[1]++;
                            return;
                        }
                        else if (valid == true)
                        {
                            Move(wall, position, newPosition, result);
                        }
                        break;

                    case "down":
                        currentRow = position[0] + 1;
                        currentCol = position[1];

                        newPosition[0] = currentRow;
                        newPosition[1] = currentCol;

                        valid = isValid(wall, currentRow, currentCol);
                        if (valid == false)
                        {
                        }
                        else if (wall[currentRow, currentCol] == 'C' && valid == true)
                        {
                            wall[position[0], position[1]] = '*';
                            wall[currentRow, currentCol] = 'E';

                            return;
                        }
                        else if (valid == true)
                        {
                            Move(wall, position, newPosition, result);
                        }
                        break;

                    case "left":
                        currentRow = position[0];
                        currentCol = position[1] - 1;

                        newPosition[0] = currentRow;
                        newPosition[1] = currentCol;

                        valid = isValid(wall, currentRow, currentCol);
                        if (valid == false)
                        {
                        }
                        else if (wall[currentRow, currentCol] == 'C' && valid == true)
                        {
                            wall[position[0], position[1]] = '*';
                            wall[currentRow, currentCol] = 'E';

                            return;
                        }
                        else if (valid == true)
                        {
                            Move(wall, position, newPosition, result);
                        }
                        break;

                    case "right":
                        currentRow = position[0];
                        currentCol = position[1] + 1;

                        newPosition[0] = currentRow;
                        newPosition[1] = currentCol;

                        valid = isValid(wall, currentRow, currentCol);
                        if (valid == false)
                        {
                        }
                        else if (wall[currentRow, currentCol] == 'C' && valid == true)
                        {
                            wall[position[0], position[1]] = '*';
                            wall[currentRow, currentCol] = 'E';

                            return;
                        }
                        else if (valid == true)
                        {
                            Move(wall, position, newPosition, result);
                        }
                        break;
                }
            }
        }


        /// <summary>
        /// Move playere up and checked what have in current cell.
        /// </summary>
        /// <param name="wall"></param>
        /// <param name="position"></param>
        private static void Move(char[,] wall, int[] position, int[] newPosition, int[] result)
        {
            if (wall[newPosition[0], newPosition[1]] == 'R')//If player hits a rod, Vanko returns to his previous position and continues with the next directions. Print "Vanko hit a rod!" and consider that he did not make a hole.
            {
                Console.WriteLine("Vanko hit a rod!");
                result[3]++;
            }
            else if (wall[newPosition[0], newPosition[1]] == '-') //If player manages to create a hole at the desired location, mark the position with a '*'. 
            {
                wall[position[0], position[1]] = '*';
                wall[newPosition[0], newPosition[1]] = 'V';

                //Change the player's current  position.
                position[0] = newPosition[0];
                position[1] = newPosition[1];

                result[2]++;
            }
            else if (wall[newPosition[0], newPosition[1]] == '*') //If player lands on a position that already has a hole on it, print "The wall is already destroyed at position [row, col]!
            {
                wall[position[0], position[1]] = '*';
                wall[newPosition[0], newPosition[1]] = 'V';

                //Change the player's current  position.
                position[0] = newPosition[0];
                position[1] = newPosition[1];

                Console.WriteLine($"The wall is already destroyed at position [{newPosition[0]}, {newPosition[1]}]!");
            }

        }

        /// <summary>
        /// If current postion is valid return "True".
        /// If current postion is invalid return "False".
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <returns></returns>
        private static bool isValid(char[,] wall, int currentRow, int currentCol)
        {
            bool result = false;

            if (currentRow >= 0 && currentRow < wall.GetLength(0) && currentCol >= 0 && currentCol < wall.GetLength(1))
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Find position of player
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private static int[] FindPosition(int r, int c)
        {
            int[] result = new int[2];

            result[0] = r;
            result[1] = c;

            return result;
        }


        /// <summary>
        /// Create wall.(suqare shape)
        /// </summary>
        /// <param name="wall"></param>
        private static int[] CreateWall(char[,] wall)
        {
            int[] position = new int[2];
            for (int r = 0; r < wall.GetLength(0); r++)
            {
                string input = Console.ReadLine();

                for (int c = 0; c < wall.GetLength(1); c++)
                {
                    wall[r, c] = input[c];

                    if (wall[r, c] == 'V')
                    {
                        position = FindPosition(r, c);
                    }
                }
            }

            return position;
        }
    }
}

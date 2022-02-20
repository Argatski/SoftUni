using System;

namespace _02.ArmoryProblemDescription
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Size of the matrix
            int n = int.Parse(Console.ReadLine());

            //Create matrix
            char[,] armory = new char[n, n];

            //Create
            CreateMatrix(armory);

            //Processing

            Processing(armory);

        }


        private static void Processing(char[,] armory)
        {
            string command = Console.ReadLine();

            int coins = 0;

            int[] positionOfficer = Position(armory);


            while (true)
            {
                string[] text = new string[2];
                text[1] = "0";

                switch (command)
                {
                    case "up":
                        text = MoveUp(armory, positionOfficer, text);

                        coins += int.Parse(text[1]);

                        if (text[0] != null)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }
                        else if (coins > 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }

                       
                        break;
                    case "down":
                        text = MoveDown(armory, positionOfficer, text);

                        coins += int.Parse(text[1]);

                        if (text[0] != null)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }
                        else if (coins > 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }

                       
                        break;
                    case "left":
                        text = MoveLeft(armory, positionOfficer, text);

                        coins += int.Parse(text[1]);

                        if (text[0] != null)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }
                        else if (coins > 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }

                       
                        break;
                    case "right":
                        text = MoveRight(armory, positionOfficer, text);
                        
                        coins += int.Parse(text[1]);

                        if (text[0] != null)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }
                        else if (coins > 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {coins} gold coins. ");
                            PrintOutput(armory);
                            return;
                        }

                    
                        break;
                }
                command = Console.ReadLine();
            }
        }


        /// <summary>
        /// Print outup
        /// </summary>
        /// <param name="armory"></param>
        private static void PrintOutput(char[,] armory)
        {
            for (int r = 0; r < armory.GetLength(0); r++)
            {
                for (int c = 0; c < armory.GetLength(1); c++)
                {
                    Console.Write(armory[r, c]);
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Move officer right.
        /// </summary>
        /// <param name="armory"></param>
        /// <param name="positionOfficer"></param>
        /// <param name="coins"></param>
        /// <returns></returns>
        private static string[] MoveRight(char[,] armory, int[] positionOfficer, string[] result)
        {
            if (isValidRight(armory, positionOfficer))
            {
                int currentCol = positionOfficer[1] + 1;
                char newPosition = armory[positionOfficer[0], currentCol];
                if (char.IsDigit(newPosition))
                {
                    result[1] += newPosition - '0';
                    armory[positionOfficer[0], currentCol] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[1] = currentCol; //col change
                }
                else if (newPosition == 'M')
                {
                    armory[positionOfficer[0], currentCol] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[1] = currentCol; //col change

                    Mirror(armory, positionOfficer);
                }
                else
                {
                    armory[positionOfficer[0], currentCol] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[1] = currentCol; //col change
                }

            }
            else
            {
                armory[positionOfficer[0], positionOfficer[1]] = '-';
                result[0] = "I do not need more swords!";

            }
            return result;
        }

        private static bool isValidRight(char[,] armory, int[] positionOfficer)
        {
            if (positionOfficer[1] + 1 > armory.GetLength(1) - 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Move officer left
        /// </summary>
        /// <param name="armory"></param>
        /// <param name="positionOfficer"></param>
        /// <param name="coins"></param>
        private static string[] MoveLeft(char[,] armory, int[] positionOfficer, string[] result)
        {

            if (isValidLeft(positionOfficer))
            {
                int currentCol = positionOfficer[1] - 1;
                char newPosition = armory[positionOfficer[0], currentCol];
                if (char.IsDigit(newPosition))
                {
                    result[1] += newPosition - '0';
                    armory[positionOfficer[0], currentCol] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[1] = currentCol; //col change
                }
                else if (newPosition == 'M')
                {
                    armory[positionOfficer[0], currentCol] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[1] = currentCol; //col change

                    Mirror(armory, positionOfficer);
                }
                else
                {
                    armory[positionOfficer[0], currentCol] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[1] = currentCol; //col change
                }

            }
            else
            {
                armory[positionOfficer[0], positionOfficer[1]] = '-';
                result[0] = "I do not need more swords!";

            }
            return result;
        }


        private static bool isValidLeft(int[] positionOfficer)
        {
            if (positionOfficer[1] - 1 >= 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Move officer down.
        /// </summary>
        /// <param name="armory"></param>
        /// <param name="positionOfficer"></param>
        /// <param name="coins"></param>
        private static string[] MoveDown(char[,] armory, int[] positionOfficer, string[] result)
        {

            if (isValidMoveDown(armory, positionOfficer))
            {
                int currentRow = positionOfficer[0] + 1;
                char newPosition = armory[currentRow, positionOfficer[1]];
                if (char.IsDigit(newPosition))
                {
                    result[1] += newPosition - '0';
                    armory[currentRow, positionOfficer[1]] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[0] = currentRow; //row change
                }
                else if (newPosition == 'M')
                {
                    armory[currentRow, positionOfficer[1]] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[0] = currentRow; //row change

                    Mirror(armory, positionOfficer);
                }
                else
                {
                    armory[currentRow, positionOfficer[1]] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[0] = currentRow; //row change
                }
            }
            else
            {
                armory[positionOfficer[0], positionOfficer[1]] = '-';
                result[0] = "I do not need more swords!";
            }
            return result;
        }

        private static bool isValidMoveDown(char[,] armory, int[] positionOfficer)
        {
            if (positionOfficer[0] + 1 > armory.GetLength(0) - 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Move officer up.
        /// </summary>
        /// <param name="armory"></param>
        /// <param name="positionOfficer"></param>
        /// <param name="coins"></param>
        private static string[] MoveUp(char[,] armory, int[] positionOfficer, string[] result)
        {
            if (isValidMoveUp(positionOfficer))
            {
                int currentRow = positionOfficer[0] - 1;
                char newPosition = armory[currentRow, positionOfficer[1]];
                if (char.IsDigit(newPosition))
                {
                    result[1] += newPosition - '0';
                    armory[currentRow, positionOfficer[1]] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[0] = currentRow; //row change
                }
                else if (newPosition == 'M')
                {
                    armory[currentRow, positionOfficer[1]] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[0] = currentRow; //row change

                    Mirror(armory, positionOfficer);
                }
                else
                {
                    armory[currentRow, positionOfficer[1]] = 'A';
                    armory[positionOfficer[0], positionOfficer[1]] = '-';

                    //Current position officer
                    positionOfficer[0] = currentRow; //row change
                }

            }
            else
            {
                armory[positionOfficer[0], positionOfficer[1]] = '-';
                result[0] = "I do not need more swords!";
            }
            return result;
        }

        /// <summary>
        /// If the army officer moves to a mirror, he teleports on the position of the other mirror.
        /// </summary>
        /// <param name="armory"></param>
        private static void Mirror(char[,] armory, int[] position)
        {
            int[] secondMirror = new int[2];

            for (int r = 0; r < armory.GetLength(0); r++)
            {
                for (int c = 0; c < armory.GetLength(1); c++)
                {
                    if (armory[r, c] == 'M')
                    {
                        secondMirror[0] = r;
                        secondMirror[1] = c;
                        goto This;
                    }
                }
            }

            This:
            armory[position[0], position[1]] = '-';
            armory[secondMirror[0], secondMirror[1]] = 'A';

            position[0] = secondMirror[0];
            position[1] = secondMirror[1];
        }

        private static bool isValidMoveUp(int[] position)
        {
            if (position[0] - 1 >= 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get the position of the officer "A".it is the first 2 elements.
        /// Get the position of mirror "M".It is the second 2.
        /// </summary>
        /// <param name="armory"></param>
        /// <returns></returns>
        private static int[] Position(char[,] armory)
        {
            int[] resultPostion = new int[2];

            for (int r = 0; r < armory.GetLength(0); r++)
            {
                for (int c = 0; c < armory.GetLength(1); c++)
                {
                    if (armory[r, c] == 'A')
                    {
                        resultPostion[0] = r;
                        resultPostion[1] = c;
                        return resultPostion;
                    }
                }
            }
            return resultPostion;
        }

        //Create matrix whit size "NxN".
        private static void CreateMatrix(char[,] armory)
        {
            for (int row = 0; row < armory.GetLength(1); row++)
            {
                string values = Console.ReadLine();
                for (int col = 0; col < values.Length; col++)
                {
                    armory[row, col] = values[col];
                }
            }
        }
    }
}

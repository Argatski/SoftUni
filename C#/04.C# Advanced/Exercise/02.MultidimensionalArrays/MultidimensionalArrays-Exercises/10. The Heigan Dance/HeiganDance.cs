using System;

namespace _10._The_Heigan_Dance
{
    class HeiganDance
    {
        static void Main(string[] args)
        {
            //Static value
            int cloudDamage = 3500;
            int eruptionDamage = 6000;
            double playerHealth = 18500;
            double heiganHealth = 3000000;
            bool cloudActive = false;

            //Input
            double playerDamage = double.Parse(Console.ReadLine());
            char[,] matrix = new char[15, 15];

            int currentRow = 7;
            int currentCol = 7;
            string currentSpell = "";

            //Processing
            while (true)
            {
                ClearMatrix(matrix);

                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                heiganHealth -= playerDamage;

                string command = input[0];

                if (cloudActive)
                {
                    playerHealth -= cloudDamage;
                    if (playerHealth <= 0)
                    {
                        Finish(heiganHealth, playerHealth, currentRow, currentCol, currentSpell);
                    }

                    cloudActive = false;
                }

                if (heiganHealth <= 0)
                {
                    Finish(heiganHealth, playerHealth, currentRow, currentCol, currentSpell);
                }

                currentSpell = input[0];
                int spellRow = int.Parse(input[1]);
                int spellCol = int.Parse(input[2]);

                CastSpell(currentSpell, spellRow, spellCol, matrix);

                if (matrix[currentRow, currentCol] != ' ')
                {
                    if (MoveUp(matrix, currentRow, currentCol))
                    {
                        currentRow--;
                    }
                    else if (MoveDown(matrix, currentRow, currentCol))
                    {
                        currentRow++;
                    }
                    else if (MoveRight(matrix, currentRow, currentCol))
                    {
                        currentCol++;
                    }
                    else if (MoveLeft(matrix, currentRow, currentCol))
                    {
                        currentCol--;
                    }
                    else
                    {
                        if (currentSpell[0] == 'C')
                        {
                            cloudActive = true;
                            playerHealth -= cloudDamage;
                        }
                        else if (currentSpell[0] == 'E')
                        {
                            playerHealth -= eruptionDamage;
                        }
                        if (playerHealth <= 0)
                        {
                            Finish(heiganHealth, playerHealth, currentRow, currentCol, currentSpell);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Move left
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <returns></returns>
        static bool MoveLeft(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentCol != 0 && matrix[currentRow, currentCol - 1] == ' ')
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Move right
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <returns></returns>
        private static bool MoveRight(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentCol != matrix.GetLength(1) - 1 && matrix[currentRow, currentCol + 1] == ' ')
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Move down
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <returns></returns>
        private static bool MoveDown(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentRow != matrix.GetLength(0) - 1 && matrix[currentRow + 1, currentCol] == ' ')
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Move up
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <returns></returns>
        private static bool MoveUp(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentRow != 0 && matrix[currentRow - 1, currentCol] == ' ')
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Cast spell
        /// </summary>
        /// <param name="currentSpell"></param>
        /// <param name="spellRow"></param>
        /// <param name="spellCol"></param>
        /// <param name="matrix"></param>
        private static void CastSpell(string currentSpell, int spellRow, int spellCol, char[,] matrix)
        {
            for (int i = spellRow - 1; i <= spellRow + 1; i++)
            {
                for (int j = spellCol - 1; j <= spellCol + 1; j++)
                {
                    if (i >= 0 && matrix.GetLength(0) > i && j >= 0 && matrix.GetLength(1) > j)
                    {
                        matrix[i, j] = currentSpell[0];
                    }
                }
            }
        }

        /// <summary>
        /// Finish
        /// </summary>
        /// <param name="heiganHealth"></param>
        /// <param name="playerHealth"></param>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <param name="currentSpell"></param>
        private static void Finish(double heiganHealth, double playerHealth, int currentRow, int currentCol, string currentSpell)
        {
            if (heiganHealth <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganHealth:f2}");
            }
            if (playerHealth <= 0)
            {
                string lastSpell = currentSpell == "Eruption" ? "Eruption" : "Plague Cloud";
                Console.WriteLine($"Player: Killed by {lastSpell}");
            }
            else
            {
                Console.WriteLine($"Player: {playerHealth}");
            }
            Console.WriteLine($"Final position: {currentRow}, {currentCol}");
            Environment.Exit(0);
        }

        /// <summary>
        /// Clear Matrix
        /// </summary>
        /// <param name="matrix"></param>
        private static void ClearMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ' ';
                }
            }
        }

        //Print matrix result
        private static void PrintMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

    }
}

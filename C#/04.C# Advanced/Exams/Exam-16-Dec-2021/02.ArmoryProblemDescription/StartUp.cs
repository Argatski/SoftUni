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

            int[] positionOfficer = Position(armory);
            int coins = 0;
            while (true)
            {
                switch (command)
                {
                    case "up":
                        MoveUp(armory, positionOfficer, coins);
                        break;
                    case "down":
                        break;
                    case "left":
                        break;
                    case "right":
                        break;
                }
            }
        }

        /// <summary>
        /// Move officer up.
        /// </summary>
        /// <param name="armory"></param>
        /// <param name="positionOfficer"></param>
        /// <param name="coins"></param>
        private static void MoveUp(char[,] armory, int[] positionOfficer, int coins)
        {
            if (isValidMoveUp(armory, positionOfficer))
            {
                int currentRow = positionOfficer[0] - 1;
                char newPosition = armory[currentRow, positionOfficer[1]];
                if (char.IsDigit(newPosition))
                {
                    coins += newPosition - '0';
                }
                if (newPosition == 'M')
                {
                    ///TODO;
                }
                armory[currentRow, positionOfficer[1]] = 'A';
                armory[positionOfficer[0], positionOfficer[1]] = '-';
            }
            else
            {
                armory[positionOfficer[0], positionOfficer[1]] = '-';
            }
        }

        private static bool isValidMoveUp(char[,] armory, int[] position)
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
            int[] resultPostion = new int[4];

            for (int r = 0; r < armory.GetLength(0); r++)
            {
                for (int c = 0; c < armory.GetLength(1); c++)
                {
                    if (armory[r, c] == 'A')
                    {
                        resultPostion[0] = r;
                        resultPostion[1] = c;
                    }
                    if (armory[r, c] == 'M') // намира и 2 м трябжани  само първото
                    {
                        resultPostion[2] = r;
                        resultPostion[3] = c;
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

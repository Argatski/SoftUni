using System;
using System.Linq;

namespace _07.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            //Input
            int row = int.Parse(Console.ReadLine());

            string[][] firstJagged = new string[row][];
            string[][] secondJagged = new string[row][];

            //Create jagged array
            CreateJaggedArray(firstJagged); // Create first jagged array

            //Reverse second jagged array by colums
            ReverseJaggedArray(secondJagged);

            //Collect the two jagged arrays
            string[][] resultMatrix = new string[row][];
            CollectJagged(firstJagged, secondJagged, resultMatrix);

            //Checked is retangular matrix.
            bool isValid = isRectangularMatrix(resultMatrix);

            //Print result
            if (!isValid)
            {
                int count = 0;
                for (int r = 0; r < resultMatrix.Length; r++)
                {
                    for (int c = 0; c < resultMatrix[r].Length; c++)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The total number of cells is: {count}");
            }
            else
            {
                foreach (string[] item in resultMatrix)
                {
                    Console.WriteLine("[" + string.Join(", ", item) + "]");
                }
            }

            //Another solution
            /*int lenght = resultMatrix[0].Length;

            if (resultMatrix.Any(a => a.Length != lenght))
            {
                Console.WriteLine($"The total number of cells is: {resultMatrix.Sum(a=>a.Length)}");
            }
            else
            {
                foreach (string[] item in resultMatrix)
                {
                    Console.WriteLine("[" + string.Join(", ", item) + "]");
                }
            }*/
        }


        /// <summary>
        /// Checked is retangular matrix.
        /// </summary>
        /// <param name="resultMatrix"></param>
        /// <returns></returns>
        static bool isRectangularMatrix(string[][] resultMatrix)
        {
            int lenghtCol = 0;

            for (int row = 0; row < resultMatrix.GetLength(0) - 1; row++)
            {
                lenghtCol = resultMatrix[row].Length;

                if (lenghtCol != resultMatrix[row + 1].Length)
                {
                    return false;
                }
            }
            return true;
        }

        static void CollectJagged(string[][] firstJagged, string[][] secondJagged, string[][] resultMatrix)
        {


            for (int i = 0; i < firstJagged.Length; i++)
            {
                int firstLenghtCol = firstJagged[i].Length;
                int secondenghtCol = secondJagged[i].Length;

                int sum = firstLenghtCol + secondenghtCol;
                resultMatrix[i] = new string[sum];

                for (int row = i; row <= i; row++)
                {
                    for (int col = 0; col < firstLenghtCol; col++)
                    {
                        resultMatrix[i][col] = firstJagged[row][col];

                        if (col == firstLenghtCol - 1)
                        {
                            for (int secondCol = 0; secondCol < secondenghtCol; secondCol++)
                            {
                                resultMatrix[i][secondCol + col + 1] = secondJagged[row][secondCol];
                            }
                        }
                    }
                }

            }
        }

        static void ReverseJaggedArray(string[][] secondJagged)
        {
            for (int row = 0; row < secondJagged.Length; row++)
            {
                string[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Array.Reverse(array);

                secondJagged[row] = new string[array.Length];

                for (int col = 0; col < array.Length; col++)
                {
                    secondJagged[row][col] = array[col];
                }

            }
        }

        /// <summary>
        /// Create jagged array
        /// </summary>
        /// <param name="jagged"></param>
        static void CreateJaggedArray(string[][] jagged)
        {
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                string[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                jagged[row] = new string[array.Length];
                for (int col = 0; col < array.Length; col++)
                {
                    jagged[row][col] = array[col];
                }
            }
        }
    }
}

using System;
using System.Linq;

namespace _07.LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int row = int.Parse(Console.ReadLine());

            string[][] firstJagged = new string[row][];
            string[][] secondJagged = new string[row][];

            //Create jagged array
            CreateJaggedArray(firstJagged); //Create first jagged array

            //Reverse second jagged array by columns
            ReverseJaggedArray(secondJagged);

            //Collect the two jagged arrays.
            string[][] resultMatrix = new string[row][];
            CollecJagged(firstJagged, secondJagged, resultMatrix);

            //Cheked is rectangular is matrix
            bool isValid = IsRectangularMatrix(resultMatrix);

            //Print Result
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
              /*
                 int length = result[0].Length;

                if (result.Any(a => a.Length != length))
                {
                    Console.WriteLine("The total number of cells is: " + result.Sum(a => a.Length));
                }
                else
                {
                    Print(result);
                }
              */
        }

        static bool IsRectangularMatrix(string[][] resultMatrix)
        {
            int lenghtCol = 0;
            for (int row = 0; row < resultMatrix.Length - 1; row++)
            {
                lenghtCol = resultMatrix[row].Length;

                if (lenghtCol != resultMatrix[row + 1].Length)
                {
                    return false;
                }
            }
            return true;
        }

        static void CollecJagged(string[][] firstJagged, string[][] secondJagged, string[][] result)
        {


            for (int i = 0; i < firstJagged.Length; i++)
            {
                int firstLenghtCol = firstJagged[i].Length;
                int secondLenghtCol = secondJagged[i].Length;

                int sum = firstLenghtCol + secondLenghtCol;
                result[i] = new string[sum];

                for (int row = i; row <= i; row++)
                {

                    for (int col = 0; col < firstLenghtCol; col++)
                    {
                        result[i][col] = firstJagged[row][col];
                        if (col == firstLenghtCol - 1)
                        {
                            for (int secondCol = 0; secondCol < secondLenghtCol; secondCol++)
                            {
                                result[i][secondCol + col + 1] = secondJagged[row][secondCol];
                            }
                        }
                    }


                }
            }

        }

        static void ReverseJaggedArray(string[][] secondJagged)
        {
            for (int row = 0; row < secondJagged.GetLength(0); row++)
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

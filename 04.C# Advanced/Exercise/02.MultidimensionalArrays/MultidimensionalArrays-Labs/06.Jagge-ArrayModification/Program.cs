using System;
using System.Linq;

namespace _06.Jagge_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[sizeMatrix][];

            //Create matrix
            CreateJaggedMatrix(jaggedMatrix);

            //Processing
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] arguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (arguments[0] == "Add")
                {
                    AddElemnts(jaggedMatrix, arguments);

                }
                else if (arguments[0] == "Subtract")
                {
                    DecreaseNumber(jaggedMatrix, arguments);
                }

                command = Console.ReadLine();
            }

            //Print result

            PrintJaggedMatrix(jaggedMatrix);
        }

        static void PrintJaggedMatrix(int[][] jaggedMatrix)
        {
            foreach (int[] numbers in jaggedMatrix)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }

        static void DecreaseNumber(int[][] jaggedMatrix, string[] arguments)
        {
            int rowIndex = int.Parse(arguments[1]);
            int colIndex = int.Parse(arguments[2]);
            int value = int.Parse(arguments[3]);

            //Case invalid coordinates
            for (int row = 0;  row < jaggedMatrix.GetLength(0); row++)
            {
                //If coordinates is invalid
                if ((jaggedMatrix.GetLength(0) <= rowIndex || rowIndex < 0) ||
                    (jaggedMatrix[row].Length <= colIndex || colIndex < 0))
                {
                    Console.WriteLine("Invalid coordinates");
                    return;
                }
            }

            //Case valid coordinates
            jaggedMatrix[rowIndex][colIndex] -= value;
        }

        private static void AddElemnts(int[][] jaggedMatrix, string[] arg)
        {
            int rowIndex = int.Parse(arg[1]);
            int colIndex = int.Parse(arg[2]);
            int value = int.Parse(arg[3]);

            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                if ((jaggedMatrix.GetLength(0) <= rowIndex || rowIndex < 0) ||
                    (jaggedMatrix[row].Length <= colIndex || colIndex < 0))
                {
                    Console.WriteLine("Invalid coordinates");
                    return;
                }
            }

            jaggedMatrix[rowIndex][colIndex] += value;
        }

        static void CreateJaggedMatrix(int[][] jaggedMatrix)
        {
            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedMatrix[row] = new int[array.Length];

                for (int col = 0; col < array.Length; col++)
                {
                    jaggedMatrix[row][col] = array[col];
                }
            }
        }
    }
}

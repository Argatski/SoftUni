using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class JaggedArrayManipulator
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfRows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[numberOfRows][];

            //Create jagged array
            CreateJaggedArray(jaggedArray);

            //Processing
            AnalyzingJaggedArray(jaggedArray);

            Processing(jaggedArray);


            //Print result
            PrintJaggedArray(jaggedArray);
        }

        /// <summary>
        /// Print jagged array whit foreach
        /// </summary>
        /// <param name="jaggedArray"></param>
        static void PrintJaggedArray(double[][] jaggedArray)
        {
            foreach (double[] array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",array));
            }
        }

        /// <summary>
        /// Then, you will receive commands. There are three possible commands:
        /// </summary>
        /// <param name="jaggedArray"></param>
        static void Processing(double[][] jaggedArray)
        {
            string arguments;

            while ((arguments = Console.ReadLine()) != "End")
            {
                string[] command = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        AddValue(jaggedArray, command);
                        break;
                    case "Subtract":
                        SubtractValue(jaggedArray, command);
                        break;
                }

            }
        }

        /// <summary>
        /// Subtract {value} from the element at the given indexes, if they are valid
        /// </summary>
        /// <param name="jaggedArray"></param>
        /// <param name="command"></param>
        static void SubtractValue(double[][] jaggedArray, string[] command)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int value = int.Parse(command[3]);

            if (row < 0 || col < 0)
            {
                return;
            }
            else if (jaggedArray.Length > row && jaggedArray[row].Length > col)
            {
                jaggedArray[row][col] -= value;
            }
        }

        /// <summary>
        /// Add {value} to the element at the given indexes, if they are valid
        /// </summary>
        /// <param name="jaggedArray"></param>
        /// <param name="command"></param>
        static void AddValue(double[][] jaggedArray, string[] command)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            double value = double.Parse(command[3]);

            if (row < 0 || col < 0)
            {
                return;
            }
            else if (jaggedArray.Length > row && jaggedArray[row].Length > col)
            {
                jaggedArray[row][col] += value;
            }
        }

        /// <summary>
        /// Start analyzing it. If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.
        /// </summary>
        /// <param name="jaggedArray"></param>
        static void AnalyzingJaggedArray(double[][] jaggedArray)
        {
            for (int rows = 0; rows < jaggedArray.Length - 1; rows++)
            {
                if (jaggedArray[rows].Length == jaggedArray[rows + 1].Length)
                {
                    for (int cols = 0; cols < jaggedArray[rows].Length; cols++)
                    {
                        jaggedArray[rows][cols] *= 2;
                        jaggedArray[rows + 1][cols] *= 2;
                    }
                }
                else
                {
                    int maxLenght = Math.Max(jaggedArray[rows].Length, jaggedArray[rows + 1].Length);
                    for (int cols = 0; cols < maxLenght; cols++)
                    {
                        if (jaggedArray[rows].Length > cols)
                        {
                            jaggedArray[rows][cols] /= 2;
                        }
                        if (jaggedArray[rows + 1].Length > cols)
                        {
                            jaggedArray[rows + 1][cols] /= 2;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Populationg jagged array (jagged matrix)
        /// </summary>
        /// <param name="jaggedArray"></param>
        static void CreateJaggedArray(double[][] jaggedArray)
        {
            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                double[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[rows] = new double[array.Length];

                for (int cols = 0; cols < array.Length; cols++)
                {
                    jaggedArray[rows][cols] = array[cols];
                }
            }
        }
    }
}

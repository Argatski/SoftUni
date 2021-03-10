using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
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


            //Print Jagged Array
            PrintJaggedArray(jaggedArray);

        }

        static void Processing(double[][] jaggedArray)
        {
            string arguments = string.Empty;

            while ((arguments = Console.ReadLine()) != "End")
            {
                string[] command = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Add":
                        AddValue(command, jaggedArray);
                        break;
                    case "Subtract":
                        SubtractValue(command, jaggedArray);
                        break;

                }
            }
        }

        /// <summary>
        /// subtract value from  the elelment at the given indexes,if they are valid.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="jaggedArray"></param>
        static void SubtractValue(string[] command, double[][] jaggedArray)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            double value = double.Parse(command[3]);

            if (row < 0 || col < 0)
            {
                return;
            }
            if (jaggedArray.Length > row && jaggedArray[row].Length > col)
            {
                jaggedArray[row][col] -= value;
            }
        }

        /// <summary>
        /// Add value to the element at the given indexes,if they are valid
        /// </summary>
        /// <param name="command"></param>
        /// <param name="jaggedArray"></param>
        static void AddValue(string[] command, double[][] jaggedArray)
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            double value = double.Parse(command[3]);

            if (row < 0 || col < 0)
            {
                return;
            }
            if (jaggedArray.Length > row && jaggedArray[row].Length > col)
            {
                jaggedArray[row][col] += value;
            }

        }

        /// <summary>
        /// Print jagged array whit foreach
        /// </summary>
        /// <param name="jaggedArray"></param>
        private static void PrintJaggedArray(double[][] jaggedArray)
        {
            foreach (double[] array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }

        static void AnalyzingJaggedArray(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                if (jaggedArray[row].Length != jaggedArray[row + 1].Length)
                {
                    int maxLength = Math.Max(jaggedArray[row].Length, jaggedArray[row + 1].Length);
                    for (int col = 0; col < maxLength; col++)
                    {
                        if (jaggedArray[row].Length > col)
                        {
                            jaggedArray[row][col] /= 2;
                        }
                        if (jaggedArray[row + 1].Length > col)
                        {
                            jaggedArray[row + 1][col] /= 2;
                        }

                    }
                }
            }

        }

        /// <summary>
        /// Create jagged array by receive rows
        /// </summary>
        /// <param name="jaggedArray"></param>
        static void CreateJaggedArray(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                double[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[row] = new double[array.Length];

                for (int col = 0; col < array.Length; col++)
                {
                    jaggedArray[row][col] = array[col];
                }
            }
        }
    }
}

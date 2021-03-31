using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] jaggedArray = new int[3][];


            for (int i = 0; i < numbers.Length; i++)
            {
                int row = 0;

                if (Math.Abs(numbers[i] % 3) == 0)
                {
                    //Processing
                    Processing(jaggedArray, row, numbers[i]);
                    
                }
                else if (Math.Abs(numbers[i] % 3) == 1)
                {
                    row = 1;
                    //Processing
                    Processing(jaggedArray, row, numbers[i]);
                                      
                }
                else if (Math.Abs(numbers[i] % 3) == 2)
                {
                    row = 2;
                    //Processing
                    Processing(jaggedArray, row, numbers[i]);
                                       
                }
            }

            //Print Matrix 

            PrintMatrix(jaggedArray);


        }

        static void PrintMatrix(int[][] jaggedArray)
        {
            foreach (int[] item in jaggedArray)
            {
                if (item !=null)
                {
                    Console.WriteLine(string.Join(" ", item));
                }
            }
        }

        private static void Processing(int[][] jaggedArray, int row, int i)
        {
            if (jaggedArray[row] == null)
            {
                jaggedArray[row] = new int[] { i };
            }
            else
            {
                int[] currentArray = jaggedArray[row];

                int currentLenght = jaggedArray[row].Length + 1;

                for (int col = currentLenght - 1; col < currentLenght; col++)
                {
                    jaggedArray[row] = new int[currentLenght];

                    jaggedArray[row][col] = i;
                }

                for (int column = 0; column < jaggedArray[row].Length - 1; column++)
                {
                    jaggedArray[row][column] = currentArray[column];
                }
            }
            
        }
    }
}

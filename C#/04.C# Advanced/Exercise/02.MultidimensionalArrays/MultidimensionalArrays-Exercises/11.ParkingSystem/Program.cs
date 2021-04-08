using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, HashSet<int>> parking = new Dictionary<int, HashSet<int>>();//row, col

            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int cols = size[1];

            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (input == "stop")
                {
                    break;
                }

                int[] arg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int entryRow = arg[0];
                int targetRow = arg[1];
                int targetCol = arg[2];

                if (!IsOccupiedSpot(parking, targetRow, targetCol))
                {
                    TakeParkingSpot(parking, targetRow, targetCol);
                    Console.WriteLine(CalcDistanceToParkingSpot(entryRow, targetRow, targetCol));
                }
                else
                {
                    targetCol = TryFindEmptySpot(parking[targetRow], targetCol, cols);
                    if (targetCol == 0)
                    {
                        Console.WriteLine($"Row {targetRow} full");
                    }
                    else
                    {
                        TakeParkingSpot(parking, targetRow, targetCol);
                        Console.WriteLine(CalcDistanceToParkingSpot(entryRow, targetRow, targetCol));
                    }
                }
            }
        }

        private static int TryFindEmptySpot(HashSet<int> parkingRow, int targetCol, int cols)
        {
            var targetColFound = 0;
            int minDistance = int.MaxValue;

            if (parkingRow.Count == cols - 1)
            {
                return targetColFound;
            }
            for (int col = 1; col < cols; col++)
            {
                var currentDistance = Math.Abs(targetCol - col);
                if (!parkingRow.Contains(col) && currentDistance < minDistance)
                {
                    targetColFound = col;
                    minDistance = currentDistance;
                }
            }
            return targetColFound;
        }

        private static long CalcDistanceToParkingSpot(int entryRow, int targetRow, int targetCol)
        {
            return Math.Abs(targetRow - entryRow) + targetCol + 1;
        }

        private static void TakeParkingSpot(Dictionary<int, HashSet<int>> parking, int row, int col)
        {
            if (!parking.ContainsKey(row))
            {
                parking[row] = new HashSet<int>();
            }
            parking[row].Add(col);
        }

        private static bool IsOccupiedSpot(Dictionary<int, HashSet<int>> parking, int row, int col)
        {
            return parking.ContainsKey(row) && parking[row].Contains(col);
        }
    }
}

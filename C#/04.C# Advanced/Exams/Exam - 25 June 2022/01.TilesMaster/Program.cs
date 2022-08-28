using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize a dictionary with tile area needed
            Dictionary<string, int> table = new Dictionary<string, int>
            {
                {"Sink", 40 },
                { "Oven", 50},
                { "Countertop", 60},
                { "Wall", 70},
            };

            //Input
            int[] white = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> whiteTiles = new Stack<int>(white);

            int[] grey = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> greyTiles = new Queue<int>(grey);

            //Processing
            Dictionary<string, int> resutl = PlaceTilesRightOrder(table, whiteTiles, greyTiles);

            //Print
            PrintResult(resutl, whiteTiles, greyTiles);
        }

        private static void PrintResult(Dictionary<string, int> resutl, Stack<int> whiteTiles, Queue<int> greyTiles)
        {
            if (whiteTiles.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(",", whiteTiles)}");
            }

            if (greyTiles.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }

            //The locations must be ordered descending by number (count of new tiles per location) and then sorted ascending alphabetically.
            resutl = resutl
                .Where(c => c.Value > 0)
                .OrderByDescending(n => n.Value)
                .ThenBy(a => a.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var tile in resutl)
            {
                Console.WriteLine($"{tile.Key}: {tile.Value}");
            }
        }

        /// <summary>
        /// Tiles place in the right order and location in the kitchen.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="whiteTiles"></param>
        /// <param name="greyTiles"></param>
        private static Dictionary<string, int> PlaceTilesRightOrder(Dictionary<string, int> table, Stack<int> whiteTiles, Queue<int> greyTiles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>
            {
                {"Sink",0 },
                {"Oven",0 },
                {"Countertop",0 },
                {"Wall",0 },
                {"Floor",0 },
            };

            while (whiteTiles.Count > 0 && greyTiles.Count > 0)
            {
                int whiteTile = whiteTiles.Peek();
                int greyTile = greyTiles.Peek();

                int largerTile = whiteTile + greyTile;

                bool isAreaEqual = table.ContainsValue(largerTile);

                //If their areas are equal, together they form a new larger tile, that the handyman will be able to use. After that, you should check whether the area of the new-formed tile matches one of the numbers in the table below (the numbers correspond to a particular location in the kitchen). The area of the new tile is formed by summing the areas of the white and the grey tile.
                if (whiteTile == greyTile && isAreaEqual == true)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();

                    var currentLocation = table.First(x => x.Value == largerTile);

                    result[currentLocation.Key]++;
                }
                //If the area of the new-formed tile matches the necessary area tile for any of the locations in the kitchen, you should remove both the grey and white tiles from the sequences. If the area doesn't match any of the specified locations, the new tile will be used for a location, named Floor. 
                else if (whiteTile == greyTile && isAreaEqual == false)
                {
                    result["Floor"]++;
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                }
                //If their areas don't match at all, you take the white tile, decrease its area in half and insert it back to the sequence. After that, you change the grey's tile position by putting it at the back of the sequence.
                else
                {
                    int newWhiteTile = whiteTiles.Pop();
                    newWhiteTile /= 2;

                    whiteTiles.Push(newWhiteTile);
                    greyTiles.Enqueue(greyTiles.Dequeue());
                }

            }
            return result;

        }
    }
}
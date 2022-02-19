using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            //First line input.
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> steel = new Queue<int>(input);


            //Second line input.
            input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> carbon = new Stack<int>(input);

            //The swords in the table.
            Dictionary<int, string> swordTable = new Dictionary<int, string>
            {
                { 70,"Gladius" },
                { 80, "Shamshir"},
                { 90, "Katana"},
                { 110, "Sabre"},
                { 150, "Broadsword"},
            };

            //Result
            Dictionary<string, int> result = new Dictionary<string, int>
            {
                { "Gladius",0 },
                { "Shamshir",0},
                { "Katana",0},
                { "Sabre", 0},
                { "Broadsword",0},
            };


            //Proccessing
            Processing(steel, carbon, swordTable, result);

            //First line of Output.
            FirstOutput(result);

            //Second line of Output.
            SecondOutput(steel);

            //Third line of Output.
            ThirdOutput(carbon);

            //Last line of Output.
            LastOutput(result);

        }

        /// <summary>
        /// Print only the swords that you manage to forge and how many of them, ordered alphabetically.
        /// </summary>
        /// <param name="result"></param>
        private static void LastOutput(Dictionary<string, int> result)
        {

            if (result.Sum(v => v.Value) > 0)
            {
                foreach (var item in result.Where(v => v.Value > 0).OrderBy(a => a.Key).ToDictionary(x => x.Key, v => v.Value))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }

        /// <summary>
        /// On the third line - print all carbon you have left:
        /// - If there are no carbon: "Carbon left: none"
        /// - If there are carbon: "Carbon left: {carbon1}, {carbon2}, {carbon3}, (…)"
        /// </summary>
        /// <param name="carbon"></param>
        private static void ThirdOutput(Stack<int> carbon)
        {
            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine("Carbon left: " + string.Join(", ", carbon));
            }
        }

        /// <summary>
        /// On the second line - print all steel you have left:
        /// - If there are no steel: "Steel left: none"
        /// - If there are steel: "Steel left: {steel1}, {steel2}, {steel3}, (…)"
        /// </summary>
        /// <param name="steel"></param>
        private static void SecondOutput(Queue<int> steel)
        {
            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine("Steel left: " + string.Join(", ", steel));
            }
        }

        /// <summary>
        /// On the first line of output depending on the result:
        /// - If at least one sword was forged: "You have forged {totalNumberOfSwords} swords."
        /// - If no sword was forged: "You did not have enough resources to forge a sword."
        /// </summary>
        /// <param name="result"></param>
        private static void FirstOutput(Dictionary<string, int> result)
        {
            if (result.Sum(x => x.Value) > 0)
            {
                Console.WriteLine($"You have forged {result.Sum(x => x.Value)} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
        }

        /// <summary>
        /// Processing
        /// </summary>
        /// <param name="steel"></param>
        /// <param name="carbon"></param>
        /// <param name="swordTable"></param>
        /// <param name="result"></param>
        private static void Processing(Queue<int> steel, Stack<int> carbon, Dictionary<int, string> swordTable, Dictionary<string, int> result)
        {
            while (steel.Count > 0 && carbon.Count > 0)
            {
                int sum = 0;
                sum = carbon.Peek() + steel.Peek();

                if (swordTable.ContainsKey(sum))
                {
                    string name = swordTable[sum];
                    result[name]++;

                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {
                    steel.Dequeue();
                    int currentCarbon = carbon.Pop();
                    currentCarbon += 5;
                    carbon.Push(currentCarbon);
                }

            }
        }
    }
}

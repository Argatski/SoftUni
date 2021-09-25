using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class FillCups
    {
        static void Main(string[] args)
        {
            //Input
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Trim()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Trim()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int wasted = 0;

            //Processing

            while (cups.Any() && bottles.Any())
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Pop();

                int result = currentCup - currentBottle;

                if (result <= 0)
                {
                    cups.Dequeue();
                    wasted += Math.Abs(result);
                }
                else if (result > 0)
                {
                    while (result > 0 && bottles.Any())
                    {
                        int anotherBottle = bottles.Pop();
                        result -= anotherBottle;

                        if (result < 0)
                        {
                            wasted += Math.Abs(result);
                        }
                    }
                    cups.Dequeue();

                }

            }

            //Print result
            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wasted}");
        }

    }
}
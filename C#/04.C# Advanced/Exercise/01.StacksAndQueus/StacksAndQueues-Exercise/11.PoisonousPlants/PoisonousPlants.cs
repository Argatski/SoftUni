using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfPlants = int.Parse(Console.ReadLine());

            int[] plants = Console.ReadLine()
                .Trim()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] daysToDie = new int[plants.Count()]; // days each plant dies(0=>plant never die)

            Stack<int> plantsLeftSeq = new Stack<int>(); // plants (indices) to the left of given plant

            plantsLeftSeq.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDaysToDie = 0;
                //Pop plants bigger than current plant and left to it.

                while (plantsLeftSeq.Count != 0 && plants[plantsLeftSeq.Peek()] >= plants[i])
                {
                    maxDaysToDie = Math.Max(maxDaysToDie, daysToDie[plantsLeftSeq.Pop()]);
                }
                // empty plants stack => min plant [i] found (smaller than all plants to the left of it)
                // min plants never die => daysToDie = 0
                if (plantsLeftSeq.Count != 0)
                {
                    daysToDie[i] = maxDaysToDie + 1;
                }
                plantsLeftSeq.Push(i);
            }
            Console.WriteLine(daysToDie.Max());
        }
    }

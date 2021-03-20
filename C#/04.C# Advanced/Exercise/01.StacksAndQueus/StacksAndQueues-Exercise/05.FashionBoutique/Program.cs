using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Stack<int> box = new Stack<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());


            int capacity = int.Parse(Console.ReadLine());


            //Processing
            Processing(capacity, box);

        }

        static void Processing(int capacity, Stack<int> box)
        {
            int sum = 0;
            int rack = 1;

            while (box.Count > 0)
            {
                int currentClothes = box.Peek();

                sum += currentClothes;

                if (sum <= capacity)
                {
                    box.Pop();
                }
                else
                {
                    rack++;
                    sum = 0;
                }
            }
                       
            Console.WriteLine(rack);
        }
    }
}

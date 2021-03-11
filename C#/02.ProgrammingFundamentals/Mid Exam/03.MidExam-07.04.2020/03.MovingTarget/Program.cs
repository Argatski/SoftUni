using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> targets = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            //Solution
            MovingTarget(targets);

        }

        static void MovingTarget(List<int> targ)
        {

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "End")
            {
                int index = int.Parse(command[1]);
                int quantity = int.Parse(command[2]);
                switch (command[0])
                {
                    case "Shoot":
                        Shoot(targ, index, quantity);
                        break;
                    case "Add":
                        AddTarget(targ, index, quantity);
                        break;
                    case "Strike":
                        Strike(targ, index, quantity);
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(String.Join("|", targ));
        }

        static void Shoot(List<int> targ, int i, int radius)
        {
            if (i >= 0 && i < targ.Count)
            {
                targ[i] -= radius;
                if (targ[i] <= 0)
                {
                    targ.RemoveAt(i);
                }
            }
        }
        static void AddTarget(List<int> targ, int i, int v)
        {
            if (targ.Count > i && i >= 0)
            {
                targ.Insert(i, v);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }
        static void Strike(List<int> targ, int i, int radius)
        {
            if (i + radius < targ.Count && i - radius >= 0)
            {
                int range = 2 * radius + 1;
                int start = i - radius;

                targ.RemoveRange(start, range);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double priceBullet = double.Parse(Console.ReadLine()); //maybe is double
            int gunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int valueIntelligence = int.Parse(Console.ReadLine());

            //Pocessing

            Stack<int> stackBullets = new Stack<int>(bullets);
            Queue<int> queueLocks = new Queue<int>(locks);

            int barrelCount = 0;

            while (queueLocks.Any() && stackBullets.Any())
            {
                int currentBullet = stackBullets.Pop();
                int currentLock = queueLocks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    queueLocks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                barrelCount++;

                if (barrelCount == gunBarrel && stackBullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    barrelCount = 0;
                }

            }

            if (stackBullets.Count == 0 && queueLocks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
            else if (queueLocks.Count == 0)
            {
                int bulletUse = bullets.Length - stackBullets.Count;

                int bulletLeft = bullets.Length - bulletUse;

                double bulletCost = bulletUse * priceBullet;

                double earnedMoney = valueIntelligence - bulletCost;

                Console.WriteLine($"{bulletLeft} bullets left. Earned ${earnedMoney}");
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            long fuel = 0;
            var queue = new Queue<long[]>();

            //Create Queue
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(Console.ReadLine().Split().Select(long.Parse).ToArray());
            }


            //Truck tour processing
            Processing(queue, fuel);
        }

        private static void Processing(Queue<long[]> queue, long fuel)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                var current = queue.Peek();
                bool isFuelEnough = true;

                for (int j = 0; j < queue.Count; j++)
                {
                    fuel += current[0];

                    if (fuel < current[1])
                    {
                        isFuelEnough = false;

                        for (int k = queue.Count - j + 1; k > 0; k--)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }
                        break;
                    }

                    fuel -= current[1];
                    queue.Enqueue(queue.Dequeue());
                    current = queue.Peek();
                }

                if (isFuelEnough)
                {
                    Console.WriteLine(i);
                    return;
                }

                fuel = 0;
            }
        }
    }
}
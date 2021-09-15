using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class FastFood
    {
        static void Main(string[] args)
        {
            //Input
            int quantity = int.Parse(Console.ReadLine());

            int[] sequenceOrders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            //Processing
            Queue<int> orders = new Queue<int>(sequenceOrders);

            //Print biggest order

            if (orders.Count > 0)
            {
                Console.WriteLine(orders.Max());
            }


            Processing(quantity, orders);

        }

        private static void Processing(int quantity, Queue<int> orders)
        {
            while (orders.Count > 0)
            {

                int currentOrder = orders.Peek();

                if (currentOrder <= quantity)
                {
                    int currentClient = orders.Dequeue();

                    quantity -= currentClient;
                }
                else
                {
                    break;
                }

            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", orders));
                return;
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int qunatityFood = int.Parse(Console.ReadLine());

            Queue<int> order = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            if (order.Count >= 0)
            {
                Console.WriteLine(order.Max());
            }

            while (order.Count > 0)
            {

                int currentClientOrder = order.Peek();
                if (qunatityFood >= currentClientOrder)
                {
                    qunatityFood -= currentClientOrder;
                    order.Dequeue();

                }
                else
                {
                    break;
                }

            }

            if (order.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", order)}");
            }

        }
    }
}

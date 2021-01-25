using System;
using System.Collections.Generic;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, int> resources = new Dictionary<string, int>();

            //Solution 
            Processing(resources);

            //PrintResult
            PrintResources(resources);
        }
        public static void PrintResources(Dictionary<string, int> r)
        {
            foreach (var i in r)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
        public static void Processing(Dictionary<string, int> r)
        {
            string arg = string.Empty;
            while ((arg = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (r.ContainsKey(arg))
                {
                    r[arg] += quantity;
                }
                else
                {
                    r.Add(arg, quantity);
                }
            }
        }
    }
}

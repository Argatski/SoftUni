using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string/*name*/, Dictionary<string/*color*/, int/*physics*/>> data = new Dictionary<string, Dictionary<string, int>>();

            //Solution add dwarfs in dictionary
            AddDwarfsInDicitionary(data);

            /*Print solution*/
            PrintDwarfSorted(data);

        }

        static void PrintDwarfSorted(Dictionary<string, Dictionary<string, int>> data)
        {
            Dictionary<string, int> sorted = new Dictionary<string, int>();

            foreach (var kvp in data.OrderByDescending(x=>x.Value.Count()))
            {
                foreach (var item in kvp.Value)
                {
                    sorted.Add($"({kvp.Key}) {item.Key} <->", item.Value);
                }
            }

            foreach (var r in sorted.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{r.Key} {r.Value}");
            }


        }

        static void AddDwarfsInDicitionary(Dictionary<string, Dictionary<string, int>> data)
        {
            string command;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] args = command.Split(" <:> ");

                string name = args[0];
                string color = args[1];
                int physics = int.Parse(args[2]);

                if (data.ContainsKey(color))
                {
                    if (data[color].ContainsKey(name))
                    {
                        int current = data[color][name];
                        int max = current > physics ? current : physics;

                        data[color][name] = max;
                    }
                    else
                    {
                        data[color].Add(name, physics);
                    }
                }
                else
                {
                    data.Add(color, new Dictionary<string, int> { { name, physics } });
                }
            }

        }
    }
}

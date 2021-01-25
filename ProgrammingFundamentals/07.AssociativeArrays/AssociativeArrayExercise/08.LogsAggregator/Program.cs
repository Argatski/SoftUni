using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> dict = new SortedDictionary<string, SortedDictionary<string, int>>();

            //Solution 
            AddIpNameInDict(n, dict);
            //Print
            PrintDict(dict);
        }

        static void PrintDict(SortedDictionary<string, SortedDictionary<string, int>> dict)
        {
            foreach (var user in dict)
            {
                int sum = user.Value.Values.Sum();

                Console.Write($"{user.Key}: {sum} ");

                Console.WriteLine($"[{string.Join(", ",user.Value.Keys)}]");
                
            }

        }

        static void AddIpNameInDict(int n, SortedDictionary<string, SortedDictionary<string, int>> dict)
        {
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[1];
                string ip = cmdArgs[0];
                int duration = int.Parse(cmdArgs[2]);
                if (dict.ContainsKey(name))
                {
                    if (dict[name].ContainsKey(ip))
                    {
                        int currentDurriton = dict[name][ip] + duration;
                        dict[name][ip] = currentDurriton;
                    }
                    else
                    {
                        dict[name][ip] = duration;
                    }
                }
                else
                {
                    dict.Add(name, new SortedDictionary<string, int>() { { ip, duration } });
                }
            }
        }
    }
}

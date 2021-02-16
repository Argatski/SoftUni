using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, Dictionary<string, int>> contest = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> statistics = new Dictionary<string, int>();


            //Solution
            Processing(contest);

            Statistics(contest, statistics);

            //Print
            PrintSolution(contest);
            PrintStatistics(statistics);

        }

        static void PrintStatistics(Dictionary<string, int> statistics)
        {
            Console.WriteLine("Individual standings:");

            int count = 0;

            foreach (var item in statistics.OrderByDescending(v => v.Value).ThenBy(k=>k.Key))
            {
                count++;
                Console.WriteLine($"{count}. {item.Key} -> {item.Value}");
            }
        }

        static Dictionary<string, int> Statistics(Dictionary<string, Dictionary<string, int>> contest, Dictionary<string, int> statistics)
        {
            foreach (var i in contest)
            {
                foreach (var user in i.Value)
                {
                    string name = user.Key;
                    int number = user.Value;

                    if (statistics.ContainsKey(name))
                    {
                        statistics[name] += number;
                        continue;
                    }

                    statistics.Add(name, number);
                }
            }
            return statistics;
        }

        static void PrintSolution(Dictionary<string, Dictionary<string, int>> contest)
        {

            
            int participiant = 0;

            foreach (var user in contest)
            {
                participiant = user.Value.Values.Count();
                Console.WriteLine($"{user.Key}: {participiant} participants");

                int count = 0;

                foreach (var item in user.Value.OrderByDescending(v => v.Value).ThenBy(k=>k.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {item.Key} <::> {item.Value}");
                }

            }
        }

        static void Processing(Dictionary<string, Dictionary<string, int>> contest)
        {
            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "no more time")
                {
                    break;
                }

                string[] args = cmd.Split(" -> ");

                string name = args[0];
                string course = args[1];
                int point = int.Parse(args[2]);

                if (contest.ContainsKey(course))
                {
                    if (contest[course].ContainsKey(name))
                    {
                        int currentPoint = contest[course][name];

                        int max = currentPoint > point ? currentPoint : point;

                        contest[course][name] = max;
                    }
                    else
                    {
                        contest[course].Add(name, point);
                    }
                }
                else
                {
                    contest.Add(course, new Dictionary<string, int> { { name, point } });
                }
            }
        }
    }
}

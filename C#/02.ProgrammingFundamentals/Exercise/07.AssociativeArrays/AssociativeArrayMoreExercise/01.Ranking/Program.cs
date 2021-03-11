using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();

            //Solution
            AddContestInDictionary(contests);
            ChekedContestAndAddUser(contests, ranking);

            //Output
            PrintResult(ranking);


        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> ranking)
        {
            string bestCandidate = string.Empty;
            int bestPoint = 0;

            foreach (var point in ranking)
            {
                int current = point.Value.Values.Sum();

                if (current > bestPoint)
                {
                    bestCandidate = point.Key;
                    bestPoint = current;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoint} points.");
            Console.WriteLine("Ranking:");

            foreach (var kvp in ranking.OrderBy(k=>k.Key))
            {
                Console.WriteLine($"{kvp.Key} ");

                foreach (var item in kvp.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }

        static void ChekedContestAndAddUser(Dictionary<string, string> contests, Dictionary<string, Dictionary<string, int>> ranking)
        {
            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "end of submissions")
                {
                    break;
                }

                string[] args = cmd.Split("=>");

                string course = args[0];
                string pass = args[1];
                string user = args[2];
                int point = int.Parse(args[3]);

                if (contests.ContainsKey(course) && contests.ContainsValue(pass))
                {
                    if (ranking.ContainsKey(user))
                    {
                        if (ranking[user].ContainsKey(course))
                        {
                            int current = ranking[user][course];

                            int max = current > point ? current : point;

                            ranking[user][course] = max;

                        }
                        else
                        {
                            ranking[user].Add(course, point);
                        }

                    }
                    else
                    {
                        ranking.Add(user, new Dictionary<string, int> { { course, point } });
                    }
                }
            }
        }

        static void AddContestInDictionary(Dictionary<string, string> dict)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] args = input.Split(":");

                string name = args[0];
                string pass = args[1];

                if (dict.ContainsKey(name) == false)
                {
                    dict.Add(name, pass);
                }
            }
        }
    }
}

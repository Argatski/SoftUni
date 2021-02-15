using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Dictionary<string, Dictionary<string, List<int>>> partcipants = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            //Solution
            Processing(partcipants, submissions);
            PrintOutput(partcipants, submissions);

        }

        static void PrintOutput(Dictionary<string, Dictionary<string, List<int>>> partcipants, Dictionary<string, int> submissions)
        {
            Dictionary<string,int> result = AddPeopleToResult(partcipants);

            Console.WriteLine("Results:");

            foreach (var kvp in result.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in submissions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }

        static Dictionary<string,int> AddPeopleToResult(Dictionary<string, Dictionary<string, List<int>>> partcipants)
        {
            var dict = new Dictionary<string, int>();

            foreach (var kvp in partcipants)
            {
                string user = kvp.Key;
                int point = 0;
                foreach (var pair in kvp.Value)
                {
                    List<int> oreder = pair.Value.OrderByDescending(x => x).ToList();
                    point = oreder[0];
                }
                dict.Add(user, point);
            }
            
            return dict;
        }

        static void Processing(Dictionary<string, Dictionary<string, List<int>>> list, Dictionary<string, int> sub)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] cmdArgs = input.Split("-");

                if (cmdArgs[1] == "banned")
                {
                    string userBanned = cmdArgs[0];
                    list.Remove(userBanned);
                    continue;
                }

                string user = cmdArgs[0];
                string technology = cmdArgs[1];
                int point = int.Parse(cmdArgs[2]);

                if (sub.ContainsKey(technology))
                {
                    sub[technology]++;
                }
                else
                {
                    sub.Add(technology, 1);
                }

                if (list.ContainsKey(user))
                {
                    if (list[user].ContainsKey(technology))
                    {
                        list[user][technology].Add(point);
                    }
                    else
                    {
                        list[user].Add(technology, new List<int> { point });
                    }
                }
                else
                {
                    list.Add(user, new Dictionary<string, List<int>> { { technology, new List<int> { point } } });
                }

            }
        }
    }
}

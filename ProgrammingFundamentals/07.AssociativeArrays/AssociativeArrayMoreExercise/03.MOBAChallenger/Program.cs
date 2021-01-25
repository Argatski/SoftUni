using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string/*user*/, Dictionary<string/*role*/, int/*point*/>> dict = new Dictionary<string, Dictionary<string, int>>();

            //Solution
            Processing(dict);

            //Print result
            PrintResult(dict);

        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> dict)
        {
            Dictionary<string, int> keepTotalPoints = new Dictionary<string, int>();

            foreach (var kvp in dict)
            {
                string currentUser = kvp.Key;
                int totalPoint = 0;
                foreach (var uvp in kvp.Value)
                {
                    totalPoint += uvp.Value;
                }
                keepTotalPoints.Add(currentUser, totalPoint);
            }

            keepTotalPoints = keepTotalPoints.OrderByDescending(x => x.Value).ThenBy(n => n.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var uvp in keepTotalPoints)
            {
                Console.WriteLine($"{uvp.Key}: {uvp.Value} skill");

                foreach (var item in dict[uvp.Key].OrderByDescending(x=>x.Value).ThenBy(n=>n.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }

        static void Processing(Dictionary<string, Dictionary<string, int>> dict)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Season end")
                {
                    break;
                }

                string[] args = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string symbol = args[1];

                switch (symbol)
                {
                    case "->":
                        AddUser(dict, args);
                        break;

                    case "vs":
                        Battle(dict, args);
                        break;
                }

            }
        }

        static void Battle(Dictionary<string, Dictionary<string, int>> dict, string[] args)
        {
            string user1 = args[0];
            string user2 = args[2];

            if (dict.ContainsKey(user1) && dict.ContainsKey(user2))
            {
                foreach (var kvp in dict[user1])
                {
                    if (dict[user2].ContainsKey(kvp.Key))
                    {
                        if (dict[user1][kvp.Key] > dict[user2][kvp.Key])
                        {
                            dict.Remove(user2);
                            break;
                        }
                        else if (dict[user1][kvp.Key] < dict[user2][kvp.Key])
                        {
                            dict.Remove(user1);
                            break;
                        }
                    }
                }
            }
        }

        static void AddUser(Dictionary<string, Dictionary<string, int>> dict, string[] args)
        {
            string user = args[0];
            string skill = args[2];
            int position = int.Parse(args[4]);

            if (dict.ContainsKey(user))
            {
                if (dict[user].ContainsKey(skill))
                {
                    int curretPoint = dict[user][skill];

                    curretPoint = curretPoint > position ? curretPoint : position;

                    dict[user][skill] = curretPoint;
                }
                else
                {
                    dict[user].Add(skill, position); ;
                }
            }
            else
            {
                dict.Add(user, new Dictionary<string, int> { { skill, position } });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary</*contest*/string, /*password*/string> list = new Dictionary<string, string>();

            //Processing
            AddContext(list);

            //Input user in contests
            SortedDictionary</*user*/string, Dictionary</*contest*/string,/*points*/int>> userSubmissions = new SortedDictionary<string, Dictionary<string, int>>();

            ResultSubmission(list, userSubmissions);

            //Print the result of  the exam.At the end you have to print the info for the user with the most points in the format:
            Print(userSubmissions);

            static void AddContext(Dictionary<string, string> list)
            {
                string input = string.Empty;

                while ((input = Console.ReadLine()) != "end of contests")
                {
                    string[] arguments = input.Split(":");
                    string contest = arguments[0];
                    string password = arguments[1];

                    if (list.ContainsKey(contest) == false)
                    {
                        list.Add(contest, password);
                    }
                }
            }
        }

        private static void Print(SortedDictionary<string, Dictionary<string, int>> userSubmissions)
        {
            var bestCandidate = string.Empty;
            var bestPoint = int.MinValue;
            foreach (var user in userSubmissions)
            {
                int point = user.Value.Values.Sum();

                if (point > bestPoint)
                {
                    bestPoint = point;
                    bestCandidate = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoint} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in userSubmissions)
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }

        static void ResultSubmission(Dictionary<string, string> list, SortedDictionary<string, Dictionary<string, int>> userSubmissions)
        {
            string data = string.Empty;

            while ((data = Console.ReadLine()) != "end of submissions")
            {
                string[] arr = data.Split("=>");

                string contest = arr[0];
                string password = arr[1];
                string userName = arr[2];
                int point = int.Parse(arr[3]);

                if (list.ContainsKey(contest) && list[contest].Contains(password))
                {
                    if (userSubmissions.ContainsKey(userName) == false)
                    {
                        userSubmissions.Add(userName, new Dictionary<string, int>() { { contest, point } });

                    }
                    else
                    {
                        if (userSubmissions[userName].ContainsKey(contest))
                        {
                            if (userSubmissions[userName][contest] == null)
                            {
                                userSubmissions[userName][contest] = point;
                            }
                            if (userSubmissions[userName][contest] < point)
                            {
                                userSubmissions[userName][contest] = point;
                            }
                        }
                        else
                        {
                            userSubmissions[userName].Add(contest, point);
                        }
                    }

                }
            }
        }
    }
}

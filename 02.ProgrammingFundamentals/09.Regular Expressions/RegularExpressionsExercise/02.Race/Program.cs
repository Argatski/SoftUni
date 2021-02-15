using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string/*participant*/, int/*distance*/> participants = new Dictionary<string, int>();

            AddingParticipant(participants);

            Processing(participants);

            PrintWiners(participants);
        }

        static void PrintWiners(Dictionary<string, int> participants)
        {
            participants = participants.OrderByDescending(n => n.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            int count = 0;
            foreach (var user in participants)
            {
                count++;
                if (count==1)
                {
                    Console.WriteLine($"1st place: {user.Key}");
                }
                else if (count==2)
                {
                    Console.WriteLine($"2nd place: {user.Key}");
                }
                else if(count==3)
                {
                    Console.WriteLine($"3rd place: {user.Key}");
                }

            }
        }

        static void Processing(Dictionary<string, int> participants)
        {
            string patternUser = @"([A-Za-z])";
            string patternDistans = @"(\d)";

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection userMatch = Regex.Matches(input, patternUser);
                string currentUser = GetUser(userMatch);

                MatchCollection distMatch = Regex.Matches(input, patternDistans);
                int currentDist = GetDistance(distMatch);

                if (participants.ContainsKey(currentUser))
                {
                    participants[currentUser] += currentDist;
                }
            }

        }
        public static int GetDistance(MatchCollection dist)
        {
            int d = 0;
            foreach (var num in dist)
            {
                string current = num.ToString();
                d += int.Parse(current);
            }

            return d;
        }
        private static string GetUser(MatchCollection userMatch)
        {
            string name = "";

            foreach (var item in userMatch)
            {
                name += item;
            }

            return name;
        }

        static void AddingParticipant(Dictionary<string, int> participants)
        {
            string[] users = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var user in users)
            {
                participants.Add(user, 0);
            }
        }
    }
}

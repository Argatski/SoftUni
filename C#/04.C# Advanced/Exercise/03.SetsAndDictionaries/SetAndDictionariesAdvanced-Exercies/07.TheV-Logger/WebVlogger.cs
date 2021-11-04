using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class WebVlogger
    {
        static void Main(string[] args)
        {
            //Input
            string input = string.Empty;

            Dictionary<string, Dictionary<string, SortedSet<string>>> web = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            //Processing
            Processing(input, web);

            //Print alles name in websiet
            Print(web);
        }

        private static void Processing(string input, Dictionary<string, Dictionary<string, SortedSet<string>>> web)
        {
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] argumments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = argumments[0];
                string command = argumments[1];
                string followedName = argumments[2];

                switch (command)
                {
                    case "joined":
                        JoinedVlogger(name, web);
                        break;
                    case "followed":
                        Followed(name, web, followedName);
                        break;
                }
            }
        }
        /// <summary>
        /// Print result
        /// </summary>
        /// <param name="web"></param>
        private static void Print(Dictionary<string, Dictionary<string, SortedSet<string>>> web)
        {
            Console.WriteLine($"The V-Logger has a total of {web.Count} vloggers in its logs.");

            int count = 0;

            web = web.OrderByDescending(v => v.Value["followers"].Count()).ThenBy(p => p.Value["following"].Count()).ToDictionary(k => k.Key, v => v.Value);

            foreach (var name in web)
            {
                count++;
                Console.WriteLine($"{count}. {name.Key} : {name.Value["followers"].Count} followers, {name.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (var item in name.Value["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }

            }
        }

        private static void Followed(string name, Dictionary<string, Dictionary<string, SortedSet<string>>> web, string followedName)
        {
            bool isTrue = web.ContainsKey(name) && web.ContainsKey(followedName) && name != followedName;
            if (isTrue)
            {
                web[followedName]["followers"].Add(name); //first index is the follwers
                web[name]["following"].Add(followedName); // second index is the following
            }
        }

        static void JoinedVlogger(string name, Dictionary<string, Dictionary<string, SortedSet<string>>> web)
        {
            if (web.ContainsKey(name) == false)
            {
                web.Add(name, new Dictionary<string, SortedSet<string>>());
                web[name].Add("followers", new SortedSet<string>());
                web[name].Add("following", new SortedSet<string>());
            }
        }
    }
}

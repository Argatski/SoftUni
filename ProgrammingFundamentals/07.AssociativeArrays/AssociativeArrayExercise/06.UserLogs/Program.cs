using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _06.userLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            SortedDictionary<string, Dictionary<string, int>> server = new SortedDictionary<string, Dictionary<string, int>>();

            //Souliton
            AddUserInDict(server);

            //PrintServerUsers
            PrintSortedUser(server);


        }

        static void PrintSortedUser(SortedDictionary<string, Dictionary<string, int>> server)
        {
            foreach (var kvp in server.Keys)
            {
                Console.WriteLine($"{kvp}: ");

                var ordered = server[kvp].OrderByDescending(x => x.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                string ipString = "";

                foreach (var ip in ordered.Keys)
                {
                    ipString+=($"{ip} => {server[kvp][ip]}, ");
                }
                ipString = ipString.Substring(0, ipString.Length - 2);
                ipString += ".";
                Console.WriteLine(ipString);
            }
        }

        static void AddUserInDict(SortedDictionary<string, Dictionary<string, int>> dict)
        {
            while (true)
            {
                string[] cmdArgs = Console.ReadLine().ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "end")
                {
                    break;
                }


                string[] ipArgs = cmdArgs[0]
                    .Split("ip=", StringSplitOptions.RemoveEmptyEntries);

                //string message = cmdArgs[1]
                //    .Split("message=", StringSplitOptions.RemoveEmptyEntries).ToString();

                string[] userArgs = cmdArgs[2]
                    .Split("user=", StringSplitOptions.RemoveEmptyEntries);

                string userIP = string.Join("", ipArgs);
                string currUser = string.Join("", userArgs);

                int count = 1;

                if (dict.ContainsKey(currUser))
                {
                    if (dict[currUser].ContainsKey(userIP))
                    {
                        dict[currUser][userIP]++;
                    }
                    else
                    {
                        dict[currUser].Add(userIP, 1);
                    }

                }
                else
                {
                    dict.Add(currUser, new Dictionary<string, int>() { { userIP, count } });
                }
            }
        }
    }
}

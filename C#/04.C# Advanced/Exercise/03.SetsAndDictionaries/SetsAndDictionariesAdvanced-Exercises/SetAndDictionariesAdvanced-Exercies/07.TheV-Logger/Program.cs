using System;
using System.Collections.Generic;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            HashSet<Dictionary<string,List<string>>> web = new HashSet<Dictionary<string, List<string>>>();

            while ((input=Console.ReadLine())!="Statistics")
            {
                string[] argumments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = argumments[0];
                string command = argumments[1];

                switch (command)
                {
                    case"joined":
                        JoinedVlogger(name, web);
                        break;
                    case"followed":
                        break;
                }
            }
        }

        static void JoinedVlogger(string name, HashSet<Dictionary<string,List<string>>> web)
        {
            web.Add(name,new List<string>());
            hash
        }
    }
}

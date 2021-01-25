using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhoneBookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            //Add contact in phonebook 
            AddContact(phonebook);

        }

        private static void AddContact(Dictionary<string, string> pb)
        {
            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "END")
                {
                    break;
                }


                switch (cmdArgs[0])
                {
                    case "A":
                        string name = cmdArgs[1];
                        string number = cmdArgs[2];
                        AddName(name, number, pb);
                        break;

                    case "S":
                        name = cmdArgs[1];
                        SearchName(name, pb);
                        break;

                    case "ListAll":
                        PrintAllList(pb);
                        break;
                }

            }
        }

        static void PrintAllList(Dictionary<string, string> pb)
        {
            pb = pb.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);
            
            foreach (var name in pb)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }

        static void SearchName(string name, Dictionary<string, string> pb)
        {
            if (pb.ContainsKey(name))
            {
                foreach (var kvp in pb)
                {
                    if (kvp.Key == name)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }

                }
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        static void AddName(string name, string number, Dictionary<string, string> pb)
        {
            if (pb.ContainsKey(name))
            {
                pb[name] = number;
            }
            else
            {
                pb.Add(name, number);
            }
        }
    }
}

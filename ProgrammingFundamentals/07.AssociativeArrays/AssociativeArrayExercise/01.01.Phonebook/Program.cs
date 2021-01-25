using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            //Solution
            Processing(phonebook);

        }

        static void Processing(Dictionary<string, string> phonebook)
        {
            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "END")
                {
                    break;
                }

                string name = cmdArgs[1];

                switch (cmdArgs[0])
                {
                    case "A":
                        string numberPhone = cmdArgs[2];
                        InputPhonebook(name, numberPhone, phonebook);
                        break;

                    case "S":
                        SearchNamePhonebook(name, phonebook);
                        break;

                }
            }
        }

        static void SearchNamePhonebook(string name, Dictionary<string, string> pb)
        {

            if (pb.ContainsKey(name))
            {
                foreach (var item in pb)
                {
                    if (item.Key == name)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        static void InputPhonebook(string name, string num, Dictionary<string, string> pb)
        {
            if (pb.ContainsKey(name))
            {
                pb[name] = num;
            }
            else
            {
                pb.Add(name, num);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            //Solution
            AddMemberInList(book);

            /* Print lis of user.You should print each force side, ordered 
            descending by forceUsers count, than ordered by name. For each 
            side print the forceUsers, ordered by name. */

            PrintResult(book);
        }

        static void PrintResult(Dictionary<string, List<string>> book)
        {
            book = book.Where(c => c.Value.Count > 0)
                .OrderBy(v => v.Value.Count)
                .ThenBy(n => n.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var side in book)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }

            }
        }

        static void AddMemberInList(Dictionary<string, List<string>> book)
        {
            while (true)
            {
                string cmdArgs = Console.ReadLine();

                if (cmdArgs == "Lumpawaroo")
                {
                    break;
                }

                if (cmdArgs.Contains("|"))
                {
                    string[] input = cmdArgs.Split(" | ").ToArray();

                    string user = input[1];
                    string side = input[0];

                    if (!ValidUserExist(book, user))
                    {
                        if (book.ContainsKey(side))
                        {
                            if (!book[side].Contains(user))
                            {
                                book[side].Add(user);
                            }
                        }
                        else
                        {
                            book.Add(side, new List<string>() { user });
                        }
                    }
                }
                else if (cmdArgs.Contains("->"))
                {
                    string[] input = cmdArgs.Split(" -> ");

                    string user = input[0];
                    string side = input[1];

                    if (ValidUserExist(book, user))
                    {
                        foreach (var kvp in book)
                        {
                            kvp.Value.Remove(user);
                        }

                        if (book.ContainsKey(side))
                        {
                            book[side].Add(user);
                        }
                        else
                        {
                            book.Add(side, new List<string>() { user });
                        }
                    }
                    else
                    {
                        if (book.ContainsKey(side))
                        {
                            book[side].Add(user);

                        }
                        else
                        {
                            book.Add(side, new List<string>() { user });
                        }

                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }
        }

        static bool ValidUserExist(Dictionary<string, List<string>> book, string user)
        {

            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(user))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

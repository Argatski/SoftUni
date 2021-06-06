using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listPeople = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //Processing
            List<string> filtered = new List<string>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Party!")
                {
                    break;
                }

                switch (command[1])
                {
                    case "StartsWith":
                        filtered = listPeople
                            .Where(p => StartWith(p, command[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "EndWith":
                        filtered = listPeople
                            .Where(p => EndsWith(p, command[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "Length":
                        filtered = listPeople
                            .Where(p => checkLenght(p, int.Parse(command[2])))
                            .Distinct()
                            .ToList();
                        break;
                }

                switch (command[0])
                {
                    case "Double":
                        listPeople = doublePeople(listPeople, filtered);
                        break;

                    case "Remove":
                        listPeople = listPeople
                            .Where(p => !filtered.Contains(p))
                            .Distinct()
                            .ToList();
                        break;
                }

                
            }
            if (listPeople.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", listPeople)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        public static Func<string, string, bool> StartWith = (a, b) => a.StartsWith(b);
        public static Func<string, string, bool> EndsWith = (a, b) => a.EndsWith(b);
        public static Func<string, int, bool> checkLenght = (a, b) => a.Length == b;

        public static Func<List<string>, List<string>, List<string>> doublePeople = (a, b) =>
          {
              foreach (string doubled in b)
              {
                  for (int i = 0; i < a.Count*2; i++)
                  {
                      if (i < a.Count)
                      {
                          if (a[i] == doubled)
                          {
                              a.Insert(i, doubled);
                              i++;
                          }
                      }
                  }
              }

              return a;
          };
    }
}

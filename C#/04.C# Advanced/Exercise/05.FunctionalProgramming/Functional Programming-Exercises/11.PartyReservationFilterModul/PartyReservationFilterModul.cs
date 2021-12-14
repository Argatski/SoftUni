using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModul
{
    class PartyReservationFilterModul
    {
        static void Main(string[] args)
        {
            //Input
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //Processing

            List<string> result = new List<string>(people);
            List<string> filtered = new List<string>();
            while (true)
            {
                //Command
                string[] command = Console.ReadLine()
                    .Split(";")
                    .ToArray();

                if (command[0] == "Print")
                {
                    break;
                }

                //Possible PRFM filter types
                switch (command[1])
                {
                    case "Starts with":
                        filtered = people
                            .Where(p => StartWhith(p, command[2])).ToList();
                        break;

                    case "Ends with":
                        filtered = people
                            .Where(p => EndsWhit(p, command[2])).ToList();
                        break;

                    case "Lenght":
                        filtered = people
                            .Where(p => CheckLenght(p, int.Parse(command[2]))).ToList();
                        break;

                    case "Contains":
                        filtered = people
                            .Where(p => IsContains(p, command[2])).ToList();
                        break;
                }

                //PRFM commands
                switch (command[0])
                {
                    case "Add filter":
                        result.RemoveAll(p => filtered.Contains(p));
                        break;
                    case "Remove filter":
                        result.AddRange(filtered);
                        result = result.Distinct().ToList();
                        break;
                }
            }

            people.RemoveAll(p => !result.Contains(p));
            Console.WriteLine(string.Join(" ", people));
        }

        public static Func<string, string, bool> StartWhith = (a, b) => a.StartsWith(b);
        public static Func<string, string, bool> EndsWhit = (a, b) => a.EndsWith(b);
        public static Func<string, int, bool> CheckLenght = (a, b) => a.Length == b;
        public static Func<string, string, bool> IsContains = (a, b) => a.Contains(b);

    }
}

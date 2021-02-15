using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numOfCommand = int.Parse(Console.ReadLine());

            //Solution
            ChekedTheList(numOfCommand);
        }

        static void ChekedTheList(int numOfCommand)
        {
            List<string> partyList = new List<string>();

            for (int i = 0; i < numOfCommand; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[1] == "is" && command[2] == "going!")
                {
                    if (partyList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(command[0]);
                    }
                }
                else
                {
                    if (partyList.Contains(command[0]))
                    {
                        partyList.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (var name in partyList)
            {
                Console.WriteLine(name);
            }
        }

    }
}

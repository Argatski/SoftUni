using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> elements = Console.ReadLine().Split(" ").ToList();

            //Solution 
            MatchesElement(elements);
        }

        static void MatchesElement(List<string> e)
        {
            int count = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "end" && e.Count > 1)
                {
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine(string.Join(" ", e));
                    break;
                }
                int firstIndex = int.Parse(command[0]);
                int secondIndex = int.Parse(command[1]);
                bool sameIndex = firstIndex == secondIndex;

                if (firstIndex >= e.Count || firstIndex < 0 || sameIndex)
                {
                    count++;
                    string added = "-" + count + "a";
                    int index = e.Count / 2;
                    e.Insert(index, added);
                    e.Insert(index, added);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (secondIndex >= e.Count || secondIndex < 0)
                {
                    count++;
                    string current = "-"+count + "a";
                    int index = e.Count / 2;
                    e.Insert(index, current);
                    e.Insert(index, current);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {

                    if (e[firstIndex] == e[secondIndex])
                    {
                        string currentNum = e[firstIndex];

                        int max = Math.Max(firstIndex, secondIndex);
                        int min = Math.Min(firstIndex, secondIndex);

                        e.RemoveAt(max);
                        e.RemoveAt(min);

                        count++;
                        Console.WriteLine($"Congrats! You have found matching elements - {currentNum}!");
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }



                if (e.Count == 0 || e.Count==1)
                {

                    Console.WriteLine($"You have won in {count} turns!");
                    break;
                }

            }
        }
    }
}

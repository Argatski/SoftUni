using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChageList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> elements = Console.ReadLine().Split()
                 .Select(int.Parse).ToList();

            //Solution
            ChageList(elements);

        }

        static void ChageList(List<int> elem)
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(' ', elem));
                    break;
                }

                int number = int.Parse(command[1]);

                if (command[0] == "Delete")
                {
                    for (int i = 0; i < elem.Count; i++)
                    {
                        if (elem[i] == number)
                        {
                            elem.Remove(number);
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int indexOf = int.Parse(command[2]);
                    elem.Insert(indexOf, number);
                }

            }
        }
    }
}

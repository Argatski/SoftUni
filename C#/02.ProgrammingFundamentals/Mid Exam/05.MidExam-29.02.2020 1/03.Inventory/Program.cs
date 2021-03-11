using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> journalCollecting = Console.ReadLine()
                .Split(", ")
                .ToList();
            //Solution
            ChekedJournalCollecting(journalCollecting);
            //Print
            Console.WriteLine(string.Join(", ", journalCollecting));
        }

        static List<string> ChekedJournalCollecting(List<string> arr)
        {
            string[] command = Console.ReadLine().Split(" - ").ToArray();

            while (command[0] != "Craft!")
            {
                string name = command[1];

                switch (command[0])
                {
                    case "Collect":

                        Collect(name, arr);
                        break;

                    case "Drop":
                        Drop(name, arr);
                        break;

                    case "Combine Items":
                        CombineItems(command, arr);
                        break;
                    case "Renew":
                        Renew(name, arr);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split(" - ").ToArray();
            }
            return arr;
        }

        static void Renew(string name, List<string> arr)
        {
            if (arr.Contains(name))
            {
                int currentItem = arr.IndexOf(name);
                string lastItem = arr[arr.Count - 1];

                arr.Insert(currentItem, lastItem);

                int last = arr.Count - 1;
                arr.Insert(last, name);

                arr.RemoveAt(currentItem + 1);
                arr.RemoveAt(last);
            }
        }

        static void CombineItems(string[] command, List<string> arr)
        {
            string text = command[1];
            string[] items = text.Split(":").ToArray();
            string oldItem = items[0];
            string newItem = items[1];

            if (arr.Contains(oldItem))
            {
                if (!arr.Contains(newItem))
                {
                    int index = arr.IndexOf(oldItem);
                    arr.Insert(index, newItem);
                }
            }
        }

        static void Drop(string name, List<string> arr)
        {
            if (arr.Contains(name))
            {
                arr.Remove(name);// remove all item maybe
            }
        }

        static void Collect(string name, List<string> arr)
        {
            if (!arr.Contains(name))
            {
                arr.Add(name);
            }

        }
    }
}

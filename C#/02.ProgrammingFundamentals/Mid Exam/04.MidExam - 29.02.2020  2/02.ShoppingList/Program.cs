using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> initialList = Console.ReadLine().Split("!").ToList();

            //Solution
            List<string> printList= WriteListShopping(initialList);
            //Print
            Console.WriteLine(string.Join(", ",printList));
        }

        static List<string> WriteListShopping(List<string> list)
        {
            string text = string.Empty;
            while ((text = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = text.Split(" ").ToArray();
                string item = command[1];

                switch (command[0])
                {
                    case "Urgent":
                        if (!list.Contains(item))
                        {
                            list.Insert(0, item);
                        }
                        break;

                    case "Unnecessary":
                        if (list.Contains(item))
                        {
                            list.Remove(item);
                        }
                        break;

                    case "Correct":
                        string newItem = command[2];

                        if (list.Contains(item))
                        {
                            int num = list.IndexOf(item);
                            list.RemoveAt(num);
                            list.Insert(num, newItem);
                        }
                        break;

                    case "Rearrange":
                        if (list.Contains(item))
                        {
                            list.Remove(item);
                            list.Add(item);
                        }
                        break;
                }
            }
            return list;
        }
    }
}

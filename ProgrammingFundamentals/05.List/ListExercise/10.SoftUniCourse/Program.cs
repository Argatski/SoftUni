using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _10.SoftUniCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //Solution
            Planning(schedule);

            //Output
            for (int i = 0; i < schedule.Count; i++)
            {
                int number = 1 + i;
                Console.WriteLine($"{number}.{schedule[i]}");
            }

        }

        static void Planning(List<string> lessons)
        {
            while (true)
            {
                string[] command = Console.ReadLine()
                        .Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "course start")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        Add(lessons, command[1]);
                        break;

                    case "Remove":
                        Remove(lessons, command[1]);
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);
                        Insert(lessons, command[1], index);
                        break;

                    case "Swap":
                        Swap(lessons, command[1], command[2]);
                        break;

                    case "Exercise":
                        Exercise(lessons, command[1]);
                        break;

                }
            }
        }
        static void Exercise(List<string> list, string title)
        {
            if (list.Contains(title))
            {
                int position = list.IndexOf(title);
                if (position + 1 < list.Count)
                {
                    if (list[position + 1] != $"{title}-Exercise")
                    {
                        list.Insert(position + 1, $"{title}-Exercise");
                    }
                }
                else
                {
                    list.Add(title + "-Exercise");
                }
            }
            else
            {
                list.Add(title);
                list.Add(title + "-Exercise");
            }
        }

        /// <summary>
        /// Chage the first and second text.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="firstTitle"></param>
        /// <param name="secondTitle"></param>
        static void Swap(List<string> list, string firstTitle, string secondTitle)
        {
            if (list.Contains(firstTitle) && list.Contains(secondTitle))
            {
                int first = list.IndexOf(firstTitle);
                int second = list.IndexOf(secondTitle);

                list[first] = secondTitle;
                list[second] = firstTitle;

                // is it range of array
                if (first + 1 < list.Count && second + 1 < list.Count)
                {
                    if (list[first + 1] == $"{firstTitle}-Exercise" &&
                        list[second + 1] == $"{secondTitle}-Exercise")
                    {
                        string temp = list[second + 1];

                        list[second + 1] = list[first + 1];
                        list[first + 1] = temp;
                    }
                    else if (list[first + 1] == $"{firstTitle}-Exercise")
                    {
                        list.Insert(second + 1, list[first + 1]);
                        if (second > first)
                        {
                            list.RemoveAt(first + 1);
                        }
                        else if (second < first)
                        {
                            list.RemoveAt(first + 2);
                        }
                    }
                    else if (list[second + 1] == $"{secondTitle}-Exercise")
                    {
                        list.Insert(first + 1, list[second + 1]);
                        if (first < second)
                        {
                            list.RemoveAt(second + 2);
                        }
                        else if (first > second)
                        {
                            list.RemoveAt(second + 1);
                        }
                    }
                }
                else if (first + 1 < list.Count)
                {
                    if (list[first + 1] == $"{firstTitle}-Exercise")
                    {
                        list.Insert(second + 1, list[first + 1]);
                        if (second > first)
                        {
                            list.RemoveAt(first + 1);
                        }
                        else if (second < first)
                        {
                            list.RemoveAt(first + 2);
                        }
                    }
                }
                else if (second + 1 < list.Count)
                {
                    if (list[second + 1] == $"{secondTitle}")
                    {
                        list.Insert(first + 1, list[second + 1]);

                        if (first < second)
                        {
                            list.RemoveAt(second + 2);
                        }
                        else if (first > second)
                        {
                            list.RemoveAt(second + 1);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert the lesson to the given index,if it does not exist.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="title"></param>
        /// <param name="index"></param>
        static void Insert(List<string> list, string title, int index)
        {
            if (!list.Contains(title))
            {
                list.Insert(index, title);
            }
        }

        /// <summary>
        /// Add or remove the lessons.If command is "Add" method add title of list.If command is "Remove" remove title of list. 
        /// </summary>
        /// <param name="list">Lessons is list of title</param>
        /// <param name="title">Title name of lesson</param>
        static void Add(List<string> list, string title)
        {
            if (!list.Contains(title))
            {
                list.Add(title);

            }
        }
        /// <summary>
        /// Remove the lesson if it exests.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="title"></param>
        static void Remove(List<string> list, string title)
        {
            if (list.Contains(title))
            {
                int index = list.IndexOf(title);

                if (index + 1 < list.Count)
                {
                    if (list[index + 1] == $"{title}-Exercise")
                    {
                        list.RemoveRange(index, 2);
                    }
                    else
                    {
                        list.Remove(title);

                    }
                }
                else
                {
                    list.Remove(title);

                }
            }
        }
    }
}

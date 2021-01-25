using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            var course = new Dictionary<string, List<string>>();

            //Solution
            ProcessingCourse(course);

            //Print
            PrintCourse(course);
        }

        static void PrintCourse(Dictionary<string,List<string>> course)
        {
            course = course
                    .OrderByDescending(x => x.Value.Count)
                    .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in course)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                List<string> user = kvp.Value.OrderBy(u => u).ToList();
                foreach (var name in user)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }

        static void ProcessingCourse(Dictionary<string, List<string>> course)
        {
            while (true)
            {
                string[] arg = Console.ReadLine().Split(" : ");
                
                if (arg[0]=="end")
                {
                    break;
                }

                string courseName = arg[0];
                string user = arg[1];
                
                if (course.ContainsKey(courseName)==false)
                {
                        course[courseName]= new List<string> {user };
                    //course.Add(courseName, new List<string> { user });
                }
                else
                {
                    course[courseName].Add(user);  
                }
            }
        }
    }
}

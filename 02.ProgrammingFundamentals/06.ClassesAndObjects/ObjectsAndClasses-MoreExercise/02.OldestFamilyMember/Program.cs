using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Family people = new Family();


            //Solution
            SetMembers(people);

            Person oldestPerson = people.GetOldestMember(people);
            //Print

            Console.WriteLine(oldestPerson.ToString());
        }

        static void SetMembers(Family people)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(" ");

                string name = person[0];
                int age = int.Parse(person[1]);

                Person p = new Person(name, age);
                people.AddMembers(p);
            }
        }
        //class Family
        //{
        //    public List<Person> People;

        //    public Family()
        //    {
        //        People = new List<Person>();
        //    }

        //    public void AddMembers(Person perCurr)
        //    {
        //        People.Add(perCurr);
        //    }

        //    public Person GetOldestMember(Family family)
        //    {
        //        List<Person> sorted = People.OrderByDescending(a => a.Age).ToList();
        //        return sorted[0];
        //    }
            

        //}
        //class Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Name} {Age}";
        //    }
        //}
    }
}

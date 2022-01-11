using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            //Instance family
            Family family = new Family();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                //Instance person
                Person person = new Person(name,age);

                family.AddMember(person);
            }

            Person oldestMember =  family.GetOldestMember();

            Console.WriteLine(oldestMember);
        }
    }
}


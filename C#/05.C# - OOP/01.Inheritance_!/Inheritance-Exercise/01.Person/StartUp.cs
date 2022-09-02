using System;

namespace _01.Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person person;
            if (age <= 15)
            {
                person = new Child(name, age);
            }
            else
            {
                person = new Person(name, age);
            }

            Console.WriteLine(person);
        }
    }
}

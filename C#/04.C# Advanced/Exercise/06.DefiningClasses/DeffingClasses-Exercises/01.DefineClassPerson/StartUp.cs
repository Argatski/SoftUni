using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instance
            /*
            Person person = new Person();
            
            person.Name = "Pesho";
            person.Age = 20;

            person.Name = "Gosho";
            person.Age = 18;

            person.Name = "Stamat";
            person.Age = 43;

            */
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho", 18);
            Person stamat = new Person("Stamat", 43);

            /*
            //Console.WriteLine(person);
            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
            Console.WriteLine(stamat);
            */
        }
    }
}

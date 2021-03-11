using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double elevatorCapacity = double.Parse(Console.ReadLine());

            double courses = numberOfPeople / elevatorCapacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}

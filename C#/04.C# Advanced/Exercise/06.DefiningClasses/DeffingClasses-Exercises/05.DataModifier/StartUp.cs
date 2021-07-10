using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            string firstData = Console.ReadLine();
            string secondDate = Console.ReadLine();

            //Instancing

            Console.WriteLine(DataModifier.Calculates(firstData,secondDate));
        }
    }
}

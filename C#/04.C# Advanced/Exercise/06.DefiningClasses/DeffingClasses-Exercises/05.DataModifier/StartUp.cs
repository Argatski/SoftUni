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

            //Instance and print rezult
            Console.WriteLine(DateModifier.Calculates(firstData,secondDate));
        }
    }
}

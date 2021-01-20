using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string concat = Console.ReadLine();

            Console.WriteLine($"{firstName}{concat}{secondName}");
        }
    }
}

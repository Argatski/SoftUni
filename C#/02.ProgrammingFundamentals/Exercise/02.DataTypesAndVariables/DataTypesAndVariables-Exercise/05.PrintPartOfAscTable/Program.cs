using System;

namespace _05.PrintPartOfAscTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLine = int.Parse(Console.ReadLine());
            int secondtLine = int.Parse(Console.ReadLine());

            for (int i = firstLine; i <= secondtLine; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}

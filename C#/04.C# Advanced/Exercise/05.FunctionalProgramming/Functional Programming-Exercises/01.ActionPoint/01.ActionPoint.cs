using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printResult(text);
        }
        public static Action<string[]> printResult = w =>
        {
            foreach (var item in w)
            {
                Console.WriteLine(item);
            }
        };
    }
}

using System;
using System.Linq;
namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCommon = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondCommon = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int count = Math.Max(firstCommon.Length, secondCommon.Length);

            string text = string.Empty;

            foreach (var index in secondCommon)
            {
                if (firstCommon.Contains(index))
                {
                    text += " " + index;
                    //Console.WriteLine($"{index}");
                }
            }
            Console.WriteLine($"{text.Trim()}");
        }
    }
}

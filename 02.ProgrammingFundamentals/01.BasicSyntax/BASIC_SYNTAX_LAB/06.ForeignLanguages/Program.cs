using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English"); break;
                case "Argentina":
                case "Spain":
                case "Mexico":
                    Console.WriteLine("Spanish"); break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

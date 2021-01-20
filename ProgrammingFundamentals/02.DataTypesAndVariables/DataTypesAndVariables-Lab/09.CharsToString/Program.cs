using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string text = (firstChar).ToString() + (secondChar).ToString()+ (thirdChar).ToString();

            Console.WriteLine(text);
        }
    }
}

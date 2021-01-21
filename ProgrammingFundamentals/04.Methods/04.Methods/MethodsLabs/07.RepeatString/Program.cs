using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();
            int repeatedTimes = int.Parse(Console.ReadLine());
            
            //Output
            RepeatString(text, repeatedTimes);
            string rezultText = RepeatString(text,repeatedTimes);
            Console.WriteLine(rezultText);
        }

        static string RepeatString(string text, int repeatedTimes)
        {
            string newText = "";
            for (int i = 0; i < repeatedTimes; i++)
            {
                newText += text;
            }
            return newText;
        }
    }
}

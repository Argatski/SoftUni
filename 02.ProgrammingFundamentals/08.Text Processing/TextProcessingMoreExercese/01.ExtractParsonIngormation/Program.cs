using System;

namespace _01.ExtractParsonIngormation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());

            //Proccessing
            ExtractInformation(num);
        }

        static void ExtractInformation(int num)
        {
            for (int i = 0; i < num; i++)
            {
                string text = Console.ReadLine();
                
                //Solution
                string name = GetNameAndAge('@', '|', text);
                string age = GetNameAndAge('#', '*', text);
                
                //Print
                Console.WriteLine($"{name} is {age} years old.");
            }
        }

        static string GetNameAndAge(char v1, char v2, string text)
        {
            int start = text.IndexOf('@');
            int end = text.IndexOf('|');
            int lenght = end - start;
            string result = text.Substring(start + 1, lenght - 1);

            return result;
        }
    }
}

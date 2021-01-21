using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            GetMax(name);
        }

        static void GetMax(string input)
        {
            if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int maxNum = GetMaxNum(num1, num2);
                Console.WriteLine(maxNum);

            }
            else if (input == "char")
            {
                char letter1 = char.Parse(Console.ReadLine());
                char letter2 = char.Parse(Console.ReadLine());

                char maxChar = GetMaxChar(letter1, letter2);
                Console.WriteLine(maxChar);
            }
            else if (input == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();

                string maxText = GetMaxString(text1, text2);
                Console.WriteLine(maxText);
            }

        }

        static string GetMaxString(string text1, string text2)
        {
            int comparison = text1.CompareTo(text2);

            if (comparison >= 0)
            {
                return text1;
            }
            else
            {
                return text2;
            }


        }

        static char GetMaxChar(int letter1, int letter2)
        {
            char getMaxChar = (char)(Math.Max(letter1, letter2));
            return getMaxChar;
        }

        static int GetMaxNum(int num1, int num2)
        {
            int getMaxNum = Math.Max(num1, num2);
            return getMaxNum;
        }
    }
}

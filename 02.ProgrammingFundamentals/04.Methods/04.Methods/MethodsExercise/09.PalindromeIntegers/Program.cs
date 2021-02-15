using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                GetPalindrome(input);
            }
        }

        static void GetPalindrome(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("false");
                    break;
                }
            }

            if (count == 1 || count == input.Length / 2)
            {
                Console.WriteLine("true");
            }
        }
    }
}

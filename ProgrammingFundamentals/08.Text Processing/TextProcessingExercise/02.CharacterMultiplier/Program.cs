using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] text = Console.ReadLine().Split(" ");

            //Solution

            int sum = CharacterMultiplier(text);

            Console.WriteLine(sum);
        }

        static int CharacterMultiplier(string[] t)
        {
            string str1 = t[0];
            string str2 = t[1];

            int sum = 0;


            int maxLenght = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < maxLenght; i++)
            {
                if (i < str1.Length && i < str2.Length)
                {
                    sum += (str1[i] * str2[i]);
                }
                else if (i >= str1.Length)
                {
                    sum += str2[i];
                }
                else if (i >= str2.Length)
                {
                    sum += str1[i];
                }
            }

            return sum;

        }
    }
}

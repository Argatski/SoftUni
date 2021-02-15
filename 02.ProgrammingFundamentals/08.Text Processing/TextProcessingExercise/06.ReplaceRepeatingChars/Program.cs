using System;
using System.Linq;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            //Solution
            ReplaceRepeatingChars(text);
        }
        static void ReplaceRepeatingChars(string t)
        {
            string result = "";
            result += t[0];
            for (int i = 1; i < t.Length; i++)
            {
                char current = t[i];

                if (current != t[i-1])
                {
                    result += t[i];
                }


            }
            Console.WriteLine(result);
        }
    }
}

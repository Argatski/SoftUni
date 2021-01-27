using System;
using System.Linq;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            RemoveChar(text, pattern);
        }

        static void RemoveChar(string text, string pattern)
        {
            bool shakeIt = true;
            while (shakeIt)
            {
                var firstIndex = text.IndexOf(pattern);
                var lastIndex = text.LastIndexOf(pattern);

                if (firstIndex + pattern.Length - 1 < lastIndex &&
                    pattern != string.Empty)
                {
                    text = text.Remove(lastIndex, pattern.Length);
                    text = text.Remove(firstIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    shakeIt = false;
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                }
            }
        }
    }
}

using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 5;

            EqualityScale<int> equalityScale = new EqualityScale<int>(first, second);

            Console.WriteLine(equalityScale.AreEqual());

            string text1 = "Denis";
            string text2 = "DeniS";

            EqualityScale<string> equalityScale1 = new EqualityScale<string>(text1, text2);

            Console.WriteLine(equalityScale1.AreEqual());
        }
    }
}

using System;

namespace _01.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int number = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            string[] result = new string[number];

            for (int i = 0; i < number; i++)
            {
                result[i] += phrases[rnd.Next(phrases.Length)] + " ";
                result[i] += events[rnd.Next(events.Length)] + " ";
                result[i] += authors[rnd.Next(authors.Length)] + " - ";
                result[i] += cities[rnd.Next(cities.Length)];
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

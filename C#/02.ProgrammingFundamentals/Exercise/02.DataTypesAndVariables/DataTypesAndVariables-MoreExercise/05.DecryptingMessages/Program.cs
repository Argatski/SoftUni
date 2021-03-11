using System;

namespace _05.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberLines = int.Parse(Console.ReadLine());
            string messegas = string.Empty;

            for (int i = 0; i < numberLines; i++)
            {
                char sumbol = char.Parse(Console.ReadLine());
                int num = sumbol+key;
                sumbol = (char) num;
                messegas += sumbol;
            }
            Console.WriteLine(messegas);
        }
    }
}

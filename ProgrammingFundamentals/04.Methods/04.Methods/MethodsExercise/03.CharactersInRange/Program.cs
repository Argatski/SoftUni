using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            char sumbol1 = char.Parse(Console.ReadLine());
            char sumbol2 = char.Parse(Console.ReadLine());

            //Output

            PrintCharacters(sumbol1, sumbol2);
        }
        static void PrintCharacters(char sumbol1, char sumbol2)
        {
            if (sumbol1<=sumbol2)
            {
                for (int i = sumbol1 + 1; i < sumbol2; i++)
                {
                    Console.Write((char)i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = sumbol2 + 1; i < sumbol1; i++)
                {
                    Console.Write((char)i + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

using System;
using System.Linq;

namespace _05._01.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLetter = Console.ReadLine()
                 .Split()
                 .Select(char.Parse)
                 .ToArray();

            char[] secondLetter = Console.ReadLine()
                 .Split()
                 .Select(char.Parse)
                 .ToArray();


            int number = Math.Max(firstLetter.Length, secondLetter.Length);

            char[] smallest = new char[number];
            char[] largest = new char[number];

            
            if (firstLetter[0] >= secondLetter[0])
            {
                smallest = secondLetter;
                largest = firstLetter;
                if (firstLetter.Length >= secondLetter.Length)
                {
                    smallest = secondLetter;
                    largest = firstLetter;
                    
                }
                else
                {
                    smallest = firstLetter;
                    largest = secondLetter;
                }
            }
            else
            {
                smallest = firstLetter;
                largest = secondLetter;
              
            }

            Console.Write(string.Join("", smallest));
            Console.WriteLine();
            Console.Write(string.Join("", largest));
            Console.WriteLine(  );

        }
    }
}

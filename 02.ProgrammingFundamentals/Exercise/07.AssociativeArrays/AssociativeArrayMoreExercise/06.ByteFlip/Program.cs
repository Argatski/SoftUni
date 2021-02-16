using System;
using System.Linq;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] byteInput = Console.ReadLine()
                .Split(" ")
                .Where(x=>x.Length==2)
                .ToArray();

            for (int i = byteInput.Length-1; i >=0 ; i--)
            {
                char[] charArray = byteInput[i].ToCharArray();
                Array.Reverse(charArray);

                Console.Write(System.Convert.ToChar(System.Convert.ToInt32(new string (charArray),16)));
            }
            Console.WriteLine();
        }
    }
}

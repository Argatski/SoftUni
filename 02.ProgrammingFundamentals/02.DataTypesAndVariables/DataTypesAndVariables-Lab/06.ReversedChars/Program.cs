﻿using System;

namespace _06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}",thirdChar,secondChar,firstChar);
        }
    }
}

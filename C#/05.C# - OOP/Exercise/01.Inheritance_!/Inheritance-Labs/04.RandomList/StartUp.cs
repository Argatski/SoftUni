using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList{ "zdrasti", "stamat", "Chao", "Pesho", "Gosho" };

            Console.WriteLine(randomList.RanodomString());

        }
    }
}

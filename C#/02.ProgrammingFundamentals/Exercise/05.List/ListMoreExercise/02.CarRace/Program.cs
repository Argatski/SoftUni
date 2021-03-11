using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input array of times
            List<int> timeOfRace = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //Solutiom
            StartRace(timeOfRace);

        }

        static void StartRace(List<int> timeOfRace)
        {
            //First car time
            double firstCarTime = 0;

            for (int i = 0; i < timeOfRace.Count/2; i++)
            {
                if (timeOfRace[i]==0)
                {
                    firstCarTime *= 0.8;
                    continue;
                }
                firstCarTime += timeOfRace[i];
            }

            //Second car time
            double secondCarTime = 0;

            for (int i = timeOfRace.Count-1; i > timeOfRace.Count / 2; i--)
            {
                if (timeOfRace[i] == 0)
                {
                    secondCarTime *= 0.8;
                    continue;
                }
                secondCarTime += timeOfRace[i];
            }

            if (firstCarTime>secondCarTime)
            {
                Console.WriteLine($"The winner is right with total time: {secondCarTime}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {firstCarTime}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenIntegers = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            var decreasedByTwo = 2;
            var input = "";
            var length = 0;
            var takeValue = 0;
            var saveLastIndex = 0;
            var counterSuccess = 0;
            var decrease = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                var command = input.Split();
                length = int.Parse(command[1]) + length;
                if (evenIntegers.Count <= length)
                {
                    length = 0;
                    var take = evenIntegers.GetRange(length, 1);
                    takeValue = take[0];
                    saveLastIndex = length;
                }
                else
                {
                    var take = evenIntegers.GetRange(length, 1);
                    takeValue = take[0];
                    saveLastIndex = length;
                }
                if (takeValue == 0)
                {
                    Console.WriteLine($"Place {saveLastIndex} already had Valentine's day.");
                    continue;
                }
                decrease = takeValue - decreasedByTwo;
                evenIntegers.RemoveAt(saveLastIndex);
                evenIntegers.Insert(saveLastIndex, decrease);
                if (decrease == 0)
                {
                    counterSuccess++;
                    Console.WriteLine($"Place {saveLastIndex} has Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {saveLastIndex}.");
            if (counterSuccess == evenIntegers.Count)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {evenIntegers.Count - counterSuccess} places.");
            }
        }
    }
}

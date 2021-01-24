using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> handFirstPlayer = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            List<int> handSecondPlayer = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            //Solution
            PlayGame(handFirstPlayer, handSecondPlayer);
        }

        static void PlayGame(List<int> handFirst, List<int> handSecond)
        {
            while (true)
            {
                if (handFirst[0] > handSecond[0])
                {
                    handFirst.Add(handFirst[0]);
                    handFirst.Add(handSecond[0]);
                }
                else if (handFirst[0]<handSecond[0])
                {
                    handSecond.Add(handSecond[0]);
                    handSecond.Add(handFirst[0]);
                }

                handFirst.Remove(handFirst[0]);
                handSecond.Remove(handSecond[0]);

                if (handFirst.Count==0)
                {
                    int sum = handSecond.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (handSecond.Count==0)
                {
                    int sum = handFirst.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }

            }
        }
    }
}

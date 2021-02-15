using System;
using System.Xml;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int initialEnergy = int.Parse(Console.ReadLine());

            //Solution
            Battle(initialEnergy);

        }

        static void Battle(int energy)
        {
            string comm;
            int wonBattles = 0;

            while (true)
            {
                comm = Console.ReadLine();

                if (comm != "End of battle")
                {
                    int distance = int.Parse(comm);
                    if (energy  <= 0)
                    {
                        Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                        break;
                    }
                    energy -= distance;
                    wonBattles++;
                }
                else
                {
                    Console.WriteLine($"Won battles: { wonBattles}. Energy left: { energy}");
                }
                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }
            }

        }
    }
}

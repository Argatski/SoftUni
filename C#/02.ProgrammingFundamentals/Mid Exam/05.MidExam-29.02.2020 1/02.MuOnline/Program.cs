using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> dungeonsRooms = Console.ReadLine().Split('|').ToList();

            //Solution
            PlayMuGame(dungeonsRooms);
        }

        private static void PlayMuGame(List<string> rooms)
        {
            string[] room = new string[2];
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                room = rooms[i].Split(" ");
                int amount = int.Parse(room[1]);

                switch (room[0])
                {
                    case "potion":
                        int diff = 100 - health;

                        if (diff > amount)
                        {
                            diff = amount;
                        }
                        if ((health + amount) < 100)
                        {
                            health += amount;
                        }
                        else
                        {
                            health = 100;
                        }
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;

                    case "chest":
                        Console.WriteLine($"You found {amount} bitcoins.");
                        bitcoins += amount;
                        break;

                    default:
                        health -= amount;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {room[0]}.");

                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {room[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        break;
                }
                if (i == rooms.Count - 1)
                {
                    Console.WriteLine($"You've made it!");
                    Console.WriteLine($"Bitcoins: {bitcoins}");
                    Console.WriteLine($"Health: {health}");
                }
            }
        }
    }
}

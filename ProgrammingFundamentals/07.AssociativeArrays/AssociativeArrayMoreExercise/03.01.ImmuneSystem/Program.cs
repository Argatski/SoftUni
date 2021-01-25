using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._01.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            double health = double.Parse(Console.ReadLine());

            Dictionary<string, double> dict = new Dictionary<string, double>();

            //Solution
            Processing(health, dict);

        }

        static void Processing(double health, Dictionary<string, double> dict)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine($"Filnal Health: {health}");
                    break;
                }

                char[] virus = command.Substring(0, command.Length).ToCharArray();

                double repeat = virus.Length;
                double time = 0;

                double sum = virus.Sum(c => c) / 3;

                double firstHelth = health;

                if (health < (health * 0.2) + health)
                {
                    health = firstHelth;
                }
                else
                {
                    health = (health * 0.2) + health - time;
                }

                if (dict.ContainsKey(command))
                {
                    time = (sum * repeat) / 3;

                    dict[command] = time;
                    Console.WriteLine($"Virus {command}: {sum} => {Math.Truncate(time)}");

                    double minute = Math.Truncate(time / 60);
                    double seconds = Math.Truncate(time % 60);

                    Console.WriteLine($"{command} defeated in {minute}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {Math.Truncate(health)}");
                    
                }
                else
                {
                    time = sum * repeat;
                    health -= time;

                    dict.Add(command, time);
                    Console.WriteLine($"Virus {command}: {sum} => {Math.Truncate(time)}");
                    double minute = Math.Truncate(time / 60);
                    double seconds = Math.Truncate(time % 60);

                    Console.WriteLine($"{command} defeated in {minute}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {Math.Truncate(health)}");
                }


                if (health <= 0)
                {
                    Console.WriteLine("Immune System Defeated");
                    break;
                }
            }
        }
    }
}

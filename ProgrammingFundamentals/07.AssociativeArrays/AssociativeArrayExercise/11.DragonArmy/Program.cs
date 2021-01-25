using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> dict = new Dictionary<string, Dictionary<string, List<int>>>();

            //Solution
            Proccesing(number, dict);

            //Print
            PrintDict(dict);
        }

        static void PrintDict(Dictionary<string, Dictionary<string, List<int>>> dict)
        {
            //Another Solution
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}::" +
                    $"({item.Value.Select(x=>x.Value[0]).Average():f2}/" +
                    $"{item.Value.Select(v=>v.Value[1]).Average():f2}/" +
                    $"{item.Value.Select(v=>v.Value[2]).Average():f2})");

                foreach (var kpv in item.Value.OrderBy(p=>p.Key))
                {
                    Console.WriteLine($"-{kpv.Key} -> damage: {kpv.Value[0]}, health: {kpv.Value[1]}, armor: {kpv.Value[2]}");
                }
            }

            /*foreach (var type in dict)
            {

                double averDamage = 0;
                double averHealth = 0;
                double averArmor = 0;

                foreach (var name in type.Value)
                {
                    averDamage += name.Value[0];
                    averHealth += name.Value[1];
                    averArmor += name.Value[2];
                }

                averDamage /= type.Value.Values.Count();
                averHealth /= type.Value.Values.Count();
                averArmor /= type.Value.Values.Count();


                Console.WriteLine($"{type.Key}::({averDamage:f2}/{averHealth:f2}/{averArmor:f2})");

                type.Key.OrderBy(x => x);
                foreach (var drag in type.Value.OrderBy(k => k.Key))
                {
                    Console.WriteLine($"-{drag.Key} -> damage: {drag.Value[0]}, health: {drag.Value[1]}, armor: {drag.Value[2]}");
                }
            }*/


        }

        static void Proccesing(int number, Dictionary<string, Dictionary<string, List<int>>> dict)
        {
            for (int i = 0; i < number; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArgs[0];
                string name = cmdArgs[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                damage = cmdArgs[2] == "null" ? 45 : int.Parse(cmdArgs[2]);
                health = cmdArgs[3] == "null" ? 250 : int.Parse(cmdArgs[3]);
                armor = cmdArgs[4] == "null" ? 10 : int.Parse(cmdArgs[4]);

                /*if (cmdArgs[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(cmdArgs[2]);
                }
                if (cmdArgs[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(cmdArgs[3]);
                }
                if (cmdArgs[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(cmdArgs[4]);
                }*/

                if (dict.ContainsKey(type))
                {
                    if (dict[type].ContainsKey(name))
                    {
                        dict[type][name][0] = damage;
                        dict[type][name][1] = health;
                        dict[type][name][2] = armor;
                    }
                    else
                    {
                        List<int> status = new List<int>();

                        status.Add(damage);
                        status.Add(health);
                        status.Add(armor);

                        dict[type].Add(name, status);
                    }
                }
                else
                {
                    List<int> status = new List<int>();

                    status.Add(damage);
                    status.Add(health);
                    status.Add(armor);

                    dict.Add(type, new Dictionary<string, List<int>> { { name, status } });
                }
            }
        }
    }
}

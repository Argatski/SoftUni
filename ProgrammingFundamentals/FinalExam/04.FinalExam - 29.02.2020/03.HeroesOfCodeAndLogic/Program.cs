using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            //Processing
            Processing(num, dict);

            Print(dict);
        }

        static void Print(Dictionary<string, List<int>> dict)
        {
            dict = dict.OrderByDescending(x => x.Value[0])
                .ThenBy(n => n.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var name in dict)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine($"  HP: {name.Value[0]}");
                Console.WriteLine($"  MP: {name.Value[1]}");
            }

        }

        static void Processing(int num, Dictionary<string, List<int>> dict)
        {
            for (int i = 0; i < num; i++)
            {
                string[] heroes = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = heroes[0];
                int HP = int.Parse(heroes[1]);
                int MP = int.Parse(heroes[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<int>() { HP, MP });
                }
                //TODO.. maybe
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command
                    .Split(" - ");

                switch (args[0])
                {
                    case "CastSpell":
                        CastSpell(args, dict);
                        break;
                    case "TakeDamage":
                        TakeDamage(args, dict);
                        break;
                    case "Recharge":
                        Recharge(args, dict);
                        break;
                    case "Heal":
                        Heal(args, dict);
                        break;
                }
            }
        }

        static void Heal(string[] args, Dictionary<string, List<int>> dict)
        {
            string name = args[1];
            int amount = int.Parse(args[2]);

            int result = dict[name][0] + amount;

            if (result > 100)
            {
                int diff = 100 - dict[name][0];

                dict[name][0] = 100;
                Console.WriteLine($"{name} healed for {diff} HP!");

            }
            else
            {
                dict[name][0] = result;
                Console.WriteLine($"{name} healed for {amount} HP!");
            }

        }

        static void Recharge(string[] args, Dictionary<string, List<int>> dict)
        {
            string name = args[1];
            int amount = int.Parse(args[2]);

            int result = dict[name][1] + amount;

            if (result > 200)
            {
                int different = 200 - dict[name][1];
                dict[name][1] = 200;

                Console.WriteLine($"{name} recharged for {different} MP!");
            }
            else
            {
                dict[name][1] = result;
                Console.WriteLine($"{name} recharged for {amount} MP!");
            }
        }

        static void TakeDamage(string[] args, Dictionary<string, List<int>> dict)
        {
            string name = args[1];
            int damage = int.Parse(args[2]);
            string attacker = args[3];

            if (dict[name][0] - damage > 0)
            {
                dict[name][0] -= damage;
                int current = dict[name][0];
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {current} HP left!");
            }
            else
            {
                dict.Remove(name);
                Console.WriteLine($"{name} has been killed by { attacker}!");
            }
        }

        static void CastSpell(string[] args, Dictionary<string, List<int>> dict)
        {
            string name = args[1];
            int mpNeeded = int.Parse(args[2]);
            string spellName = args[3];

            if (dict[name][1] >= mpNeeded)
            {
                int result = dict[name][1] - mpNeeded;
                dict[name][1] = result;
                Console.WriteLine($"{name} has successfully cast {spellName} and now has {result} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
            }
        }
    }
}

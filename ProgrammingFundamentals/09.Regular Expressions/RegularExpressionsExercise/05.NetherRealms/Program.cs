using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] demos = Console.ReadLine()
                .Split(",");

            List<Demons> demosList = new List<Demons>();

            for (int i = 0; i < demos.Length; i++)
            {
                string currentDemo = demos[i].Trim(' ');

                double health = GetHealth(currentDemo);
                decimal damage = GetDamage(currentDemo);

                Demons demon = new Demons(demos[i], health, damage);
                demosList.Add(demon);
            }

            PrintOutPut(demosList);
        }

        static void PrintOutPut(List<Demons> demosList)
        {
            foreach (var demon in demosList.OrderBy(a => a.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        static decimal GetDamage(string currentDemo)
        {
            decimal damage = 0;

            string pattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            MatchCollection rgx = Regex.Matches(currentDemo, pattern);

            foreach (var num in rgx)
            {
                damage += decimal.Parse(num.ToString());
            }

            foreach (var c in currentDemo.Where(c => c == '*' || c == '/'))
            {

                if (c == '*')
                {
                    damage *= 2;
                }
                else
                {
                    damage /= 2;
                }

            }
            return damage;
        }

        static double GetHealth(string name)
        {
            double result = 0;

            string pattern = @"[^0-9+\-*\/./]";

            var rg = Regex.Matches(name, pattern);

            for (int i = 0; i < rg.Count; i++)
            {
                string sym = (rg[i].ToString());
                result += char.Parse(sym);
            }
            return result;
        }
        /*  class Demons
          {
              public string Name { get; set; }
              public double Health { get; set; }
              public decimal Damage { get; set; }

              public Demons(string name, double healt, decimal damage)
              {
                  Name = name;
                  Health = healt;
                  Damage = damage;
              }

          }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double cash = double.Parse(Console.ReadLine()); // maybe is a  decimal

            List<int> initialQualitys = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //Solution
            Practies(cash, initialQualitys);
            //Outupt
        }

        static void Practies(double cash, List<int> initialQualitys)
        {
            string hitPower;
            List<int> currentQuality = new List<int>();

            currentQuality.AddRange(initialQualitys);

            while ((hitPower = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(hitPower);

                for (int i = 0; i < currentQuality.Count; i++)
                {
                    currentQuality[i] -= power;
                    if (currentQuality[i] <= 0)
                    {
                        currentQuality[i] = initialQualitys[i];

                        if (cash < 0 || cash < initialQualitys[i] * 3)
                        {
                            currentQuality[i]=0;
                            continue;
                        }
                        cash -= (initialQualitys[i] * 3);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", currentQuality.FindAll(x=>x>0))); // This print everything bigger of zero
            Console.WriteLine($"Gabsy has {cash:f2}lv.");
        }
    }
}

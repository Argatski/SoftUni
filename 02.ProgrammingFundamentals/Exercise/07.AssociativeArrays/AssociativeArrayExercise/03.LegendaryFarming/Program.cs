using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"fragments",0},
                { "motes",0},
                { "shards",0}

            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemCrafted = string.Empty;

            //Solution
            Proccessing(materials, junk, ref itemCrafted);
            //Print
            PrintMaterials(materials, junk, itemCrafted);
        }

        static void PrintMaterials(Dictionary<string, int> materials, Dictionary<string, int> junk, string itemCrafted)
        {
            Console.WriteLine($"{itemCrafted} obtained!");

            materials = materials.OrderByDescending(m => m.Value)
               .ThenBy(x => x.Key)
               .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            junk = junk.OrderBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        static void Proccessing(Dictionary<string, int> materials, Dictionary<string, int> junk, ref string itemCrafted)
        {
            bool hasCraftItem = false;

            while (true)
            {
                if (hasCraftItem)
                {
                    break;
                }

                string[] cmdArgs = Console.ReadLine().Split();

                for (int i = 0; i < cmdArgs.Length; i += 2)
                {
                    int quantity = int.Parse(cmdArgs[i]);
                    string product = cmdArgs[i + 1].ToLower();

                    if (materials.ContainsKey(product))
                    {
                        materials[product] += quantity;
                        if (materials[product] >= 250)
                        {
                            hasCraftItem = true;
                            if (product == "fragments")
                            {
                                itemCrafted = "Valanyr";
                            }
                            else if (product == "shards")
                            {
                                itemCrafted = "Shadowmourne";
                            }
                            else if (product == "motes")
                            {
                                itemCrafted = "Dragonwrath";
                            }
                            materials[product] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(product))
                        {
                            junk[product] += quantity;
                        }
                        else
                        {
                            junk.Add(product, quantity);
                        }
                    }
                }
            }
        }
    }
}

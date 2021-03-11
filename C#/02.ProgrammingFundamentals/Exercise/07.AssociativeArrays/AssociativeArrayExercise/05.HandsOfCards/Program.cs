using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            Dictionary<string, List<string>> handsCards = new Dictionary<string, List<string>>();

            //Solution
            AddCardsInHadn(handsCards);

            CalculateTotalValue(handsCards);

        }

        static void CalculateTotalValue(Dictionary<string, List<string>> dict)
        {

            foreach (var item in dict)
            {
                int sum = 0;

                foreach (var card in item.Value.Distinct())
                {
                    int result = 0;
                    switch (card.Substring(0, card.Length - 1))
                    {
                        case "2":
                            result = 2;
                            break;
                        case "3":
                            result = 3;
                            break;
                        case "4":
                            result = 4;
                            break;
                        case "5":
                            result = 5;
                            break;
                        case "6":
                            result = 6;
                            break;
                        case "7":
                            result = 7;
                            break;
                        case "8":
                            result = 8;
                            break;
                        case "9":
                            result = 9;
                            break;
                        case "10":
                            result = 10;
                            break;
                        case "J":
                            result = 11;
                            break;
                        case "Q":
                            result = 12;
                            break;
                        case "K":
                            result = 13;
                            break;
                        case "A":
                            result = 14;
                            break;
                    }

                    switch (card.Substring(card.Length - 1))
                    {
                        case "S":
                            result *= 4;
                            break;

                        case "H":
                            result *= 3;
                            break;

                        case "D":
                            result *= 2;
                            break;

                        case "C":
                            result *= 1;
                            break;
                    }

                    sum = sum + result;

                }
                Console.WriteLine($"{item.Key}: {sum}");
            }
        }

        static void AddCardsInHadn(Dictionary<string, List<string>> hand)
        {
            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];

                if (name == "JOKER")
                {
                    break;
                }


                if (hand.ContainsKey(name))
                {
                    var list = cmdArgs[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    var concatList = hand[cmdArgs[0]].Concat(list).Distinct().ToList();

                    hand[name] = concatList;
                }
                else
                {
                    var list = cmdArgs[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    hand.Add(name, list);



                }
            }

        }
    }
}

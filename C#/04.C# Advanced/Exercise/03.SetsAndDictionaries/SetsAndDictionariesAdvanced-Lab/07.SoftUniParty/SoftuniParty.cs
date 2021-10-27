using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class SoftuniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> vipList = new HashSet<string>();
            HashSet<string> regularList = new HashSet<string>();

            //Fill list guests
            Fill(vipList, regularList);

            //Cheked guests
            CheckedAllGuests(vipList, regularList);

            //Print result
            Print(vipList, regularList);
        }

        /// <summary>
        /// Print list of guests
        /// </summary>
        /// <param name="vipList"></param>
        /// <param name="regularList"></param>
        private static void Print(HashSet<string> vipList, HashSet<string> regularList)
        {
            int count = vipList.Count + regularList.Count;
            Console.WriteLine(count);

            foreach (var guest in vipList)
            {
                Console.WriteLine($"{guest}");
            }

            foreach (var guest in regularList)
            {
                Console.WriteLine($"{guest}");
            }
        }

        /// <summary>
        /// Cheked all guests
        /// </summary>
        /// <param name="vipList"></param>
        /// <param name="regularList"></param>
        private static void CheckedAllGuests(HashSet<string> vipList, HashSet<string> regularList)
        {
            string guest = string.Empty;

            while ((guest=Console.ReadLine())!="END")
            {
                if (vipList.Contains(guest))
                {
                    vipList.Remove(guest);
                }
                if (regularList.Contains(guest))
                {
                    regularList.Remove(guest);
                }
            }
        }

        /// <summary>
        /// Fill list of guest
        /// </summary>
        /// <param name="vipList"></param>
        /// <param name="regularList"></param>
        private static void Fill(HashSet<string> vipList, HashSet<string> regularList)
        {
            string currentGuest = string.Empty;

            while ((currentGuest = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(currentGuest[0]))
                {
                    vipList.Add(currentGuest);
                }
                else
                {
                    regularList.Add(currentGuest);
                }
            }
        }
    }
}

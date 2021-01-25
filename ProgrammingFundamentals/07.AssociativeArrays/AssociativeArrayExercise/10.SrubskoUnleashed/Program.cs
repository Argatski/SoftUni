using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, ulong>> dict = new Dictionary<string, Dictionary<string, ulong>>();

            //Solution
            Processing(dict);

            //Print favorite music
            PrintDict(dict);


        }

        static void PrintDict(Dictionary<string, Dictionary<string, ulong>> dict)
        {

            foreach (var venue in dict)
            {
                Console.WriteLine(venue.Key);

                foreach (var name in venue.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {name.Key}-> {name.Value}");
                }
            }
        }

        static void Processing(Dictionary<string, Dictionary<string, ulong>> dict)
        {
            while (true)
            {
                string cmdArgs = Console.ReadLine();

                if (cmdArgs == "End")
                {
                    break;
                }

                string[] checkInvalid = cmdArgs.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool startWithAt = false;

                foreach (var elemnt in checkInvalid)
                {
                    if (elemnt.StartsWith("@"))
                    {
                        startWithAt = true;
                    }
                }

                if (startWithAt == false)
                {
                    continue;
                }

                long digit;

                bool isDigit = long.TryParse(checkInvalid[checkInvalid.Length - 1], out digit);
                bool isDigit1 = long.TryParse(checkInvalid[checkInvalid.Length - 2], out digit);

                if (isDigit == false || isDigit1 == false)
                {
                    continue;
                }

                if (checkInvalid.Length < 4)
                {
                    continue;
                }

                string[] arr = cmdArgs.Split("@");

                string preformer = arr[0];

                string[] venuePriceTicekts = arr[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                ulong ticketCount = ulong.Parse(venuePriceTicekts[venuePriceTicekts.Length - 1]);
                ulong tickentPrice = ulong.Parse(venuePriceTicekts[venuePriceTicekts.Length - 2]);
                ulong TotalPrce = ticketCount * tickentPrice;

                string[] venueArr = venuePriceTicekts.SkipLast(2).ToArray();

                string venue = string.Join(" ", venueArr);

                if (dict.ContainsKey(venue))
                {
                    if (dict[venue].ContainsKey(preformer))
                    {
                        dict[venue][preformer] += TotalPrce;
                    }
                    else
                    {
                        dict[venue].Add(preformer, TotalPrce);
                    }
                }
                else
                {
                    dict.Add(venue, new Dictionary<string, ulong> { { preformer, TotalPrce } });
                }
            }
        }
    }
}

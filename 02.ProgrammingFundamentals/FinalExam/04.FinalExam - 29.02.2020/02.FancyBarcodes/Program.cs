using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pattern
            int number = int.Parse(Console.ReadLine());
            string validBarcode = @"^@#+(?<barcodes>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";

            //Processing
            GetValidBarcode(number, validBarcode);
        }

        static void GetValidBarcode(int number, string pattern)
        {
            string patternProduct = @"(?<num>[\d])";
            Regex rgx = new Regex(pattern);

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                //Get Valid Barcode
                Match match = rgx.Match(input);
                string barcode = match.Groups["barcodes"].Value;

                if (match.Success)
                {
                    //Get Product gorup
                    Regex numMatch = new Regex(patternProduct);
                    MatchCollection numGroup = numMatch.Matches(barcode);

                    string sb = string.Empty;

                    foreach (Match item in numGroup)
                    {
                        if (item.Success)
                        {
                            sb += item.Groups["num"].Value;
                        }
                    }

                    if (sb.Length == 0)
                    {
                        sb = "00";
                    }
                    Console.WriteLine($"Product group: {sb}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int key = int.Parse(Console.ReadLine());

            string messages = string.Empty;


            while ((messages = Console.ReadLine())!="end")
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < messages.Length; i++)
                {
                    char current = (char)(messages[i] - key);
                    sb.Append(current);
                }

                string decodeText= sb.ToString();

                string pattern = @"(@)(?<name>[A-Za-z]*)(?<sep>[^@\-!:>]*)(?<mark>[!])(?<type>[GN])(\k<mark>)";

                Regex rgx = new Regex(pattern);

                Match match = rgx.Match(decodeText);

                string name = match.Groups["name"].Value;
                string type = match.Groups["type"].Value;

                if (type=="G")
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}

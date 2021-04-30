using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dict = new List<string>();
            using (StreamReader rd = new StreamReader("../../../Input1.txt"))
            {
                string text1 = rd.ReadLine();
                while (text1 != null)
                {
                    dict.Add(text1);
                    text1 = rd.ReadLine();
                }


            }
            using (StreamReader rd2 = new StreamReader("../../../Input2.txt"))
            {
                string text2 = rd2.ReadLine();
                while (text2 != null)
                {
                    dict.Add(text2);
                    text2 = rd2.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                dict.Sort();
                foreach (var item in dict)
                {
                    writer.WriteLine($"{item}");
                }
            }
        }
    }
}



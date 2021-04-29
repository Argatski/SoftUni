using System;
using System.IO;

namespace _02.LineNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {

                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    string line = reader.ReadLine();
                    int count = 0;

                    while (line != null)
                    {
                        count++;
                        writer.WriteLine($"{count}. {line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

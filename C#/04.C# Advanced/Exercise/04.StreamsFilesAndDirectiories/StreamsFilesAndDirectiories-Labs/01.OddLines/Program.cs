using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../input.txt");

            using (reader)
            {
                int count = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line != null)
                    {
                        if (count % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                    
                }
            }
        }
    }
}

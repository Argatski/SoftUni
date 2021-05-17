using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "Text.txt";
            string outputPath = "Output.txt";

            var textLines = File.ReadAllLines(textPath);

            int lineCounter = 1;

            foreach (var line in textLines)
            {
                int lettersCount = line.Count(char.IsLetter);
                int punctuationCount = line.Count(char.IsPunctuation);

                File.AppendAllText(outputPath, $"Line {lineCounter}: {line} ({lettersCount})({punctuationCount}){Environment.NewLine}");

                lineCounter++;
            }
        }
    }
}

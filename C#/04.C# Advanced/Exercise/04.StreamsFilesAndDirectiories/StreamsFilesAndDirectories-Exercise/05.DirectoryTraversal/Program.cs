using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            var directoruInfo = new DirectoryInfo(".");

            var allFiles = directoruInfo.GetFiles();

            foreach (var currentFile in allFiles)
            {
                double size = (double)currentFile.Length / 1024; //1024 because is MB

                string fileName = currentFile.Name;
                string extension = currentFile.Extension;
                if (dirInfo.ContainsKey(extension) == false)
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (dirInfo[extension].ContainsKey(fileName) == false)
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }

            //If you need a report file in a Desktop
            /*string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";*/

            string path = "../../../report.txt";

            var sortedDir = dirInfo
                .OrderBy(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in sortedDir)
            {
                File.AppendAllText(path, kvp.Key + Environment.NewLine);
                foreach (var file in kvp.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{file.Key} - {Math.Round(file.Value),3}kb" + Environment.NewLine);
                }
            }
        }
    }
}

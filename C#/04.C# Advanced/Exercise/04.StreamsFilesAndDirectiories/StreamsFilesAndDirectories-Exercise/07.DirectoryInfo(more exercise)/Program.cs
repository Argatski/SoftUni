using System;
using System.IO;

namespace _07.DirectoryInfo_more_exercise_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input path folder
            string folderPath = Console.ReadLine();

            //Print solution
            Console.WriteLine(ScanFolderRecursively(folderPath, 0));
        }

        static double ScanFolderRecursively(string folderPath, int indentation)
        {
            double fileSize = 0;

            try
            {
                var files = Directory.GetFiles(folderPath);

                var directories = Directory.GetDirectories(folderPath);

                foreach (var directory in directories)
                {
                    fileSize += ScanFolderRecursively(directory, indentation);
                }

                foreach (var filePath in files)
                {
                    FileInfo file = new FileInfo(filePath);

                    Console.WriteLine($"{new string(' ', indentation)} {file.FullName}");

                    fileSize += file.Length;
                }
            }

            catch (Exception)
            {

                throw;
            }

            return fileSize / 1024 / 1024;
        }
    }
}

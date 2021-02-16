using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string filePath = Console.ReadLine();

            int nameStart = filePath.LastIndexOf("\\") + 1;

            int extensionStat = filePath.LastIndexOf(".") + 1;

            string fileName = filePath.Substring(nameStart, extensionStat - nameStart - 1);
            string fileExtension = filePath.Substring(extensionStat, filePath.Length - extensionStat);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");


            //Another Solution
            /*
             string[] file = Console.ReadLine().Split("\\");

            string[] path = file.Last().Split(".");
            string fileName = path[0];
            string extension = path[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
             */
        }
    }
}

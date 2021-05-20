using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipFile = @"..\..\..\result.zip";
            string picPath = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(picPath, Path.GetFileName(picPath));
            }

            ZipFile.ExtractToDirectory("../../../rezult.zip", "../../../");

            //using (var extract = ZipFile.Open("../../../rezult.zip", ZipArchiveMode.Read))
            //{
            //    extract.ExtractToDirectory("../../../");
            //}

        }
    }
}

using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string picPath = "../../../copyMe.png";
            string picCopyPath = "../../../copyMe-copy.png";

            using (FileStream file = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream wr = new FileStream(picCopyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        var readSize = file.Read(buffer, 0, buffer.Length);

                        if (readSize==0)
                        {
                            break;
                        }
                        file.Write(buffer, 0, readSize);

                    }
                }
            }
        }
    }
}

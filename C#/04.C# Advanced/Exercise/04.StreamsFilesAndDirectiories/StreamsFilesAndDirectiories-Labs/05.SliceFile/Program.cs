using System;
using System.IO;

namespace _05.SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                byte[] buffer = new byte[reader.Length/4];

                for (int i = 0; i < reader.Length/buffer.Length; i++)
                {
                    reader.Read(buffer, 0, buffer.Length);

                    using (FileStream writeStream = new FileStream($"../../../{i+1}.SliceMe.txt",FileMode.Create,FileAccess.Write))
                    {
                        writeStream.Write(buffer);
                    }
                }
            }
        }
    }
}

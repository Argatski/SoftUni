using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            //Solution
            EncryptedText(text);
        }

        static void EncryptedText(string text)
        {
            StringBuilder encryptText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                encryptText.Append(Convert.ToChar(text[i] + 3));
            }
            Console.WriteLine(encryptText);
        }
    }
}

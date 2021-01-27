using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            string text = Console.ReadLine();

            //Solution
            Processing(text);
        }

        static void Processing(string text)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}

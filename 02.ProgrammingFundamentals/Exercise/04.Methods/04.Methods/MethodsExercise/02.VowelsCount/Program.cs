using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string word = Console.ReadLine().ToLower();

            //Output

            int resultCounter =  VowelsCount(word);
            Console.WriteLine(resultCounter);
        }

        static int VowelsCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}

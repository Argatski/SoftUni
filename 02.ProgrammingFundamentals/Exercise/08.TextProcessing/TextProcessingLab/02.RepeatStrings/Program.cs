using System;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] cmdArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            //Solution
            StringBuilder sb = new StringBuilder();

            foreach (string word in cmdArray)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb);
            
            /* Another Solution
            string result = "";
            for (int i = 0; i < cmdArray.Length; i++)
            {
                string word = cmdArray[i];

                for (int j = 0; j < word.Length; j++)
                {
                    result += word; 
                }
            }
            Console.WriteLine(result);
            */
        }
    }
}

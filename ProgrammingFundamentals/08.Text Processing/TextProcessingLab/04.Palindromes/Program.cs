using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            char[] separators = { ',', '?', '!', '.', ' ' };

            string[] input = Console.ReadLine()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries);

            //Solution
            Palindromes(input);
        }

        static void Palindromes(string[] inpust)
        {
            List<string> palindromes = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                string wordRevers = "";

                for (int r = word.Length-1; r >= 0; r--)
                {
                    wordRevers += word[r];
                }

                if (word==wordRevers)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            Console.WriteLine(string.Join(", ",palindromes));
        }

        //Another solution
        /*
         private static bool IsPalyndrome(string word)
    {
        if (word.Length == 1)
            return true;
        int len = word.Length;
        for(int i=0; i<len/2; i++){
            if(word[i] != word[len-i-1])
                return false;
        }
        return true;
    }

    static void Main()
    {
        char[] delimiters = {' ', ',', '.', '?', '!' };
        SortedSet<string> palyndromes = new SortedSet<string>();
        List<string> words = Console.ReadLine().
            Split(delimiters, StringSplitOptions.RemoveEmptyEntries).
            Select(p => p.Trim()).ToList();

        foreach(string word in words){              
            if (IsPalyndrome(word))
                palyndromes.Add(word);
        }
        Console.WriteLine(string.Join(", ", palyndromes));
    }  
         
         */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] name = new string[number];
            int[] numberOfName = new int[number];


            for (int i = 0; i < number; i++)
            {
                name[i] = Console.ReadLine();
            }


            for (int i = 0; i < name.Length; i++)
            {
                string letterName = name[i];
                int output = 0;


                for (int k = 0; k < letterName.Length; k++)
                {
                    char symbol = letterName[k];

                    switch (symbol)
                    {
                        case 'a': output += symbol * letterName.Length; break;
                        case 'e': output += symbol * letterName.Length; break;
                        case 'i': output += symbol * letterName.Length; break;
                        case 'o': output += symbol * letterName.Length; break;
                        case 'u': output += symbol * letterName.Length; break;
                        case 'A': output += symbol * letterName.Length; break;
                        case 'E': output += symbol * letterName.Length; break;
                        case 'I': output += symbol * letterName.Length; break;
                        case 'O': output += symbol * letterName.Length; break;
                        case 'U': output += symbol * letterName.Length; break;

                        default:
                            output += symbol / letterName.Length;
                            break;
                    }

                }

                numberOfName[i] = output;
            }

            Array.Sort(numberOfName);

            foreach (var item in numberOfName)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Linq;

namespace _05.PlayCatch
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = 0;

            while (n < 3)
            {
                string[] command = Console.ReadLine()
                    .Split();

                try
                {
                    switch (command[0])
                    {
                        case "Replace":
                            int index = int.Parse(command[1]);
                            int element = int.Parse(command[2]);
                            elements[index] = element;
                            break;
                        case "Print":
                            int start = int.Parse(command[1]);
                            int end = int.Parse(command[2]);

                            int[] resutl = new int[end - start + 1];

                            for (int i = 0; i < resutl.Length; i++)
                            {
                                resutl[i] = elements[start + i];
                            }
                            Console.WriteLine(string.Join(", ", resutl));
                            break;
                        case "Show":
                            int indexPrint = int.Parse(command[1]);
                            Console.WriteLine(elements[indexPrint]);
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    n++;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    n++;

                }

            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}

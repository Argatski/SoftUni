using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            List<int> currentPassegers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int capacitiy = int.Parse(Console.ReadLine());
               //Solution 
            getPassegers(currentPassegers,capacitiy);


        }

        static void getPassegers(List<int> currentPassegers,int cap)
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(' ', currentPassegers));
                    break;
                }
                if (command[0] == "Add")
                {
                    int passWithWagons = int.Parse(command[1]);
                    currentPassegers.Add(passWithWagons);
                }
                else
                {
                    int pass = int.Parse(command[0]);

                    for (int i = 0; i < currentPassegers.Count; i++)
                    {
                        int sum = pass + currentPassegers[i];
                        if (sum<=cap)
                        {
                            currentPassegers[i]=sum;
                            break;
                        }
                    }
                }
            }
        }
    }
}

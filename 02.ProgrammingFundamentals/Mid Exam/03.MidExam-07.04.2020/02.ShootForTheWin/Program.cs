using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //Solution
            ShotingTargets(targets);
            
        }
        static void ShotingTargets(List<int> targ) 
        {
            string command;

            while ((command=Console.ReadLine())!="End")
            {
                int index = int.Parse(command);
                
                if (index>targ.Count-1)
                {
                    continue;
                }

                int currentTarget = targ[index];

                targ[index] = -1;

                for (int i = 0; i < targ.Count; i++)
                {
                    if (targ[i]<=currentTarget)
                    {
                        if (targ[i]>-1)
                        {
                            targ[i] += currentTarget;
                        }
                        
                    }
                    else
                    {
                        if (targ[i]>-1)
                        {
                            targ[i] -= currentTarget;
                        }
                        
                    }
                }
            }
            int count = 0;

            for (int i = 0; i < targ.Count; i++)
            {
                if (targ[i]==-1)
                {
                    count++;
                }
            }

            Console.Write($"Shot targets: {count} -> ");
            Console.WriteLine(String.Join(" ",targ));
        }
    }
}

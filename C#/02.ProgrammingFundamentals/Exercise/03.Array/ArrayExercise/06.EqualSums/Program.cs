using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;

            bool found = false;
            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int pos = 0; pos < arr.Length; pos++) //searching
            {
                //Sum left number for current possition

                for (int L = 0; L < pos; L++)
                {
                    leftSum += arr[L];
                }

                for (int R = pos + 1; R < arr.Length; R++)
                {
                    rightSum += arr[R];
                }

                //check if sum are EQUAL

                if (rightSum == leftSum)
                {
                    Console.WriteLine(pos);
                    found = true;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (found == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}

////Another Solution////
//int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//List<int> index = new List<int>();
           
//            for (int i = 0; i<nums.Length; i++)            
//                if(nums.Take(i).Sum() == nums.Skip(i+1).Take(nums.Length-i).Sum())
//                    index.Add(i);    
           
//            if(index.Count > 0)
//                Console.WriteLine(string.Join(", ", index));
//            else
//                Console.WriteLine("no");

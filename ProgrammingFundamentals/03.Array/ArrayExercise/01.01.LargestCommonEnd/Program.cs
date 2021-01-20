using System;

namespace _01._01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] firstText = Console.ReadLine()
                .Split();

                string[] secondText = Console.ReadLine()
                    .Split();

                int countLeft = 0;
                int countRignt = 0;

                int smallestLength = Math.Min(firstText.Length, secondText.Length);

                for (int i = 0; i < smallestLength; i++)
                {

                    if (firstText[i] == secondText[i])
                    {
                        countLeft++;
                    }

                }

                for (int i = smallestLength-1; i > 0; i--)
                {

                    if (firstText[firstText.Length - i] == secondText[secondText.Length - i])
                    {
                        countRignt++;
                    }

                }
                int realCount = 0;
                if (countLeft > countRignt)
                {
                    realCount = countLeft;
                }
                else
                {
                    realCount = countRignt;
                }

                Console.WriteLine(realCount);
            }
        }
    }
}
//Another Solution///
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LargestCommonEndv2
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] firstArr = Console.ReadLine().Split();
//            string[] secondArr = Console.ReadLine().Split();
//            int smallerArr = Math.Min(firstArr.Length, secondArr.Length);
//            int leftCorner = 0;
//            int rightCorner = 0;
//            for (int left = 0; left < smallerArr; left++)
//            {
//                if (firstArr[left] == secondArr[left])
//                {
//                    leftCorner++;
//                }
//                else
//                {
//                    break;
//                }
//            }
//            Array.Reverse(firstArr);
//            Array.Reverse(secondArr);
//            for (int right = 0; right < smallerArr; right++)
//            {
//                if (secondArr[right] == firstArr[right])
//                {
//                    rightCorner++;
//                }
//                else
//                {
//                    break;
//                }
//            }
//            Console.WriteLine(Math.Max(leftCorner, rightCorner));
//        }
//    }
//}
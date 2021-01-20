using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split("");

            Array.Reverse(inputText);

            foreach (var index in inputText)
            {
                Console.WriteLine(index);
            }
        }
    }
}


//using System;

//namespace _04.ReverseString
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string inputText = Console.ReadLine();

//            for (int i = inputText.Length - 1; i >= 0; i--)
//            {
//                Console.Write(inputText[i]);
//            }
//            Console.WriteLine();
//        }
//    }
//}


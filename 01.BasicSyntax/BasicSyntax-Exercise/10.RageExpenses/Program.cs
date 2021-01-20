using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double trashedHeadset = Math.Floor(lostGamesCount / 2.0);
            double trashedMouse = Math.Floor(lostGamesCount / 3.0);
            double trashedkeyboard = Math.Floor(lostGamesCount / 6.0);
            double trashedDisplay = Math.Floor(lostGamesCount / 12.0);

            double totalExpenses = (headsetPrice * trashedHeadset) + (mousePrice * trashedMouse) + (keyboardPrice * trashedkeyboard) + (displayPrice * trashedDisplay);


            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}

//namespace P10_RageExpenses
//{
//    using System;

//    class P10_RageExpenses
//    {
//        static void Main(string[] args)
//        {
//            int lostGames = int.Parse(Console.ReadLine());
//            double headsetPrice = double.Parse(Console.ReadLine());
//            double mousePrice = double.Parse(Console.ReadLine());
//            double keyboardPrice = double.Parse(Console.ReadLine());
//            double displayPrice = double.Parse(Console.ReadLine());

//            int headsetCount = 0;
//            int mouseCount = 0;
//            int keyboardCount = 0;
//            int displayCount = 0;

//            for (int i = 1; i <= lostGames; i++)
//            {
//                bool isHeadsetTrashed = false;
//                bool isMouseTrashed = false;
//                if (i % 2 == 0)
//                {
//                    isHeadsetTrashed = true;
//                    headsetCount++;
//                }

//                if (i % 3 == 0)
//                {
//                    isMouseTrashed = true;
//                    mouseCount++;
//                }

//                if (isHeadsetTrashed && isMouseTrashed)
//                {
//                    keyboardCount++;
//                    if (keyboardCount % 2 == 0)
//                    {
//                        displayCount++;
//                    }
//                }
//            }

//            double expenses = (headsetCount * headsetPrice) + (mouseCount * mousePrice) + (keyboardCount * keyboardPrice) + (displayCount * displayPrice);
//            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
//        }
//    }
//}


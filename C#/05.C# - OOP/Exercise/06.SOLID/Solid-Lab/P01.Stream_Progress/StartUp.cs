using System;
namespace P01.Stream_Progress
{
    using StreamProgressInfo.Models;
    using StreamProgressInfo.Core;
    public class StartUp
    {
        static void Main()
        {
            File file = new File("Abba", 125, 10);
            Music music = new Music("Queen", "The game", 1000, 220);

            StreamProgressInfo first = new StreamProgressInfo(file);
            StreamProgressInfo second = new StreamProgressInfo(music);

            Console.WriteLine(first.CalculateCurrentPercent());
            Console.WriteLine(second.CalculateCurrentPercent());
        }
    }
}

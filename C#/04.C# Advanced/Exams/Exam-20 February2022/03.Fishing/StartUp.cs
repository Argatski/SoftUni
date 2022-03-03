using System;

namespace FishingNet
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize the repository(Net)
            Net net = new Net("cast net", 10);

            //Initialize entity
            Fish fishOne = new Fish("selmon", 44.25, 941.15);
            Fish fishSecond = new Fish("catfish", 105.25, 2100.15);
            Fish fishThird = new Fish("bass", 25.25, 321.15);

            //Is not valid
            //Fish fishFour = new Fish("bass", 25.25, 321.15);

            //Add Fish
            Console.WriteLine(net.AddFish(fishOne));
            Console.WriteLine(net.AddFish(fishSecond));
            Console.WriteLine(net.AddFish(fishThird));
            //Console.WriteLine(net.Add(fishFour));

            foreach (var fish in net.Fish)
            {
                Console.WriteLine(fish);
            }

            //// Remove Fish
            Console.WriteLine(net.ReleaseFish(321.15));  // True
            Console.WriteLine(net.Count); // 2


            Fish fishFour = new Fish("mullet", 15.21, 150.33);
            Fish fishFive = new Fish("barbel", 21.33, 190.14);
            Fish fishSix = new Fish("trout", 38.35, 357.41);

            // Add Fish
            Console.WriteLine(net.AddFish(fishFour));
            Console.WriteLine(net.AddFish(fishFive));
            Console.WriteLine(net.AddFish(fishSix));

            //// GetFish
            Console.WriteLine(net.GetFish("trout"));
            Console.WriteLine(net.GetFish("Trout"));

            //// GetBiggestFish
            Console.WriteLine(net.GetBiggestFish());

            //Report
            Console.WriteLine("----------------------Report----------------------");
            Console.WriteLine(net.Report());


        }

    }
}

using System;

namespace GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfString = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfString; i++)
            {
                var text = Console.ReadLine();

                Box<string> box = new Box<string>(text);

                Console.WriteLine(box);
            }
        }
    }
}

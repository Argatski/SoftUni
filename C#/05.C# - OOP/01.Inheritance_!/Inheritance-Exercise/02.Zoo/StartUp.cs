using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake("Pesho");
            Console.WriteLine(snake.Name);
        }
    }
}

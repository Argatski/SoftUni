using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int durationGreen = int.Parse(Console.ReadLine());
            int durationWindow = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            //Processing
            string input = string.Empty;

            int count = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green")
                {
                    int greenLight = durationGreen;
                    int passSeconds = durationWindow;

                    while (queue.Count != 0 && greenLight > 0)
                    {

                        string currentCar = queue.Dequeue();

                        int lenght = currentCar.Count();

                        greenLight -= lenght;

                        if (greenLight > 0)
                        {
                            count++;
                        }
                        else
                        {
                            passSeconds += greenLight;
                            if (passSeconds < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar[lenght + passSeconds]}.");
                                return;
                            }
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
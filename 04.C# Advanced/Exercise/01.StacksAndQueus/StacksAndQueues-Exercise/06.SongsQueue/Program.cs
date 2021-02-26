using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                .Split(", "));

            //Processing
            Processing(songs);

            //Print End
            Console.WriteLine("No more songs!");

        }

        static void Processing(Queue<string> songs)
        {
            while (songs.Count > 0)
            {
                string arg = Console.ReadLine();

                string command = arg.Substring(0, 4);


                switch (command)
                {
                    case "Add ":
                        AddSong(songs, arg);
                        break;
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
        }

        static void AddSong(Queue<string> songs, string arg)
        {
            string nameOfSong = arg.Substring(4, arg.Length-4);

            if (songs.Contains(nameOfSong))
            {
                Console.WriteLine($"{nameOfSong} is already contained!");
            }
            else
            {
                songs.Enqueue(nameOfSong);
            }
        }
    }
}

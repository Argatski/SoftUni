using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Songs> collection = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] data = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries);

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Songs song = new Songs(); // classes

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                collection.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Songs song in collection)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in collection)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }

                }
            }
            //Another Solution
            //List<Songs> filteredSongs = collection.Where(s => s.TypeList == typeList).ToList();//Filter collection whit string typeList

            //foreach (Songs song in filteredSongs)
            //{
            //    Console.WriteLine(song.Name);
            //}

        }
    }
}

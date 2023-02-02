using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int numberSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberSongs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (input.Length != 3)
                    {
                        throw new InvalidSongExeption();
                    }
                    ParserSong(songs, input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            PrintTotalTime(songs);
        }

        private static void PrintTotalTime(List<Song> songs)
        {
            long totalSecond = songs.Sum(m => m.Minutes * 60) + songs.Sum(s => s.Seconds);
            TimeSpan ts = TimeSpan.FromSeconds(totalSecond);
            Console.WriteLine($"Songs added: {songs.Count()}");
            Console.WriteLine($"Playlist length: {ts.Hours}h {ts.Minutes}m {ts.Seconds}s");
        }

        private static void ParserSong(List<Song> songs, string[] input)
        {
            string[] time = input[2]
                .Split(":", StringSplitOptions.RemoveEmptyEntries);

            int minutes;
            int seconds;

            if (int.TryParse(time[0], out minutes) && int.TryParse(time[1], out seconds))
            {
                Song song = new Song(input[0], input[1], minutes, seconds);

                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            else
            {
                throw new InvalidSongLengthException();
            }
        }
    }
}

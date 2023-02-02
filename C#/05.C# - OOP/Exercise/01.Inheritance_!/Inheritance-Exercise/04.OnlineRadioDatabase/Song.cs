using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Song
    {
        //Fields artist
        private const int ArtistMinLength = 3;
        private const int ArtistMaxLength = 20;
        //Fields song
        private const int SongMinLength = 3;
        private const int SongtMaxLength = 20;
        //Fields song minutes
        private const int MinMinutes = 0;
        private const int MaxMinutes = 14;
        //Fields song seconds
        private const int MinSeconds = 0;
        private const int MaxSeconds = 59;

        //Fields
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        //Constructor
        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;

        }

        //Properties 
        //Minutes
        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < MinMinutes || value > MaxMinutes)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }

        }

        //Seconds
        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < MinSeconds || value > MaxSeconds)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        //Song name properties
        public string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < SongMinLength || value.Length > SongtMaxLength)
                {
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }
        //Artist name  properties
        public string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < ArtistMinLength || value.Length > ArtistMaxLength)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }
    }
}

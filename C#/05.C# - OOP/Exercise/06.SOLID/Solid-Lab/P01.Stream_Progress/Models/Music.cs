﻿using StreamProgressInfo.Models.Interfaces;

namespace StreamProgressInfo.Models
{
    public class Music : IStreamable
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent)
        {
            this.artist = artist;
            this.album = album;
            Length = length;
            BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}

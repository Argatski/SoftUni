using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongLengthException : InvalidSongExeption
    {
        public override string Message => "Invalid song length.";
    }
}

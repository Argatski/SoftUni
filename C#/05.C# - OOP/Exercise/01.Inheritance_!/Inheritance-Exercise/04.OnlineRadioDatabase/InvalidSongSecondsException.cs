using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public override string Message => "Song seconds should be between 0 and 59.";
    }
}

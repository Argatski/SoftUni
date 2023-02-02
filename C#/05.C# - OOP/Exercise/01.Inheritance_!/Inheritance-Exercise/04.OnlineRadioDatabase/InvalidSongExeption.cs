using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongExeption : Exception
    {
        public override string Message
        {
            get { return "Invalid song."; }
        }
    }
}

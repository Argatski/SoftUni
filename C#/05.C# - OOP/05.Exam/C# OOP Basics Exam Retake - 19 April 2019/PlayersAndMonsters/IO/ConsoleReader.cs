﻿using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}

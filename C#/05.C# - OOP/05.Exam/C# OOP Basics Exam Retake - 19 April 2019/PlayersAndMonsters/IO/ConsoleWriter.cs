using PlayersAndMonsters.IO.Contracts;
using System;

namespace PlayersAndMonsters.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(object message) => Console.Write(message);

        public void WriteLine(object message) => Console.WriteLine(message);
    }
}

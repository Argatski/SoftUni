using PlayersAndMonsters.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Commands
{
    public class Command : ICommand
    {
        public Command(string name, string[] arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }
        public string Name { get; private set; }

        public string[] Arguments { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Command
    {
        public Command(string name, string[] arguments)
        {
            this.Name = name;
            this.Argumetns = arguments;
        }

        public string Name { get; private set; }
        public string[] Argumetns { get; private set; }
    }
}

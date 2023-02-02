using System;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var commandParser = new CommandParser();
            var engine = new Engine(commandParser);

            engine.Run();
        }
    }
}

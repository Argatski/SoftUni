using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Engine
    {
        private CommandParser commandParser;
        private List<Team> teams;
        public Engine(CommandParser commandParser)
        {
            this.commandParser = commandParser;
            this.teams = new List<Team>();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    var command = commandParser.Parse(input);
                    var teamName = command.Argumetns[0];

                    if (command.Name == "Team")
                    {
                        var team = new Team(teamName);
                        this.teams.Add(team);
                    }
                    else if (command.Name == "Add")
                    {
                        this.ValidateTeamName(teamName);

                        var player = this.CreatePlayer(command);
                        var team = this.teams.FirstOrDefault(t => t.Name == teamName);

                        team.AddPlayer(player);
                    }
                    else if (command.Name == "Remove")
                    {
                        this.ValidateTeamName(teamName);

                        var playerName = command.Argumetns[1];

                        var team = this.teams.FirstOrDefault(t => t.Name == teamName);

                        team.RemovePlayer(playerName);
                    }
                    else if (command.Name == "Rating")
                    {
                        this.ValidateTeamName(teamName);

                        var team = this.teams.FirstOrDefault(t => t.Name == teamName);

                        Console.WriteLine(team);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                input = Console.ReadLine();
            }
        }
        private Player CreatePlayer(Command command)
        {
            var playerName = command.Argumetns[1];
            var stat = this.CreateStat(command);

            return new Player(playerName, stat);
        }
        private Stat CreateStat(Command command)
        {
            var endurance = int.Parse(command.Argumetns[2]);
            var sprint = int.Parse(command.Argumetns[3]);
            var dribble = int.Parse(command.Argumetns[4]);
            var passing = int.Parse(command.Argumetns[5]);
            var shooting = int.Parse(command.Argumetns[6]);

            return new Stat(endurance, sprint, dribble, passing, shooting);
        }
        private void ValidateTeamName(string name)
        {
            var team = this.teams.FirstOrDefault(n => n.Name == name);
            if (team == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessage.invalidTeamNema, name));
            }
        }
    }
}

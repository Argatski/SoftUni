using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int numberOfTeamsToBeRegistered = int.Parse(Console.ReadLine());

            RegisterTeams(numberOfTeamsToBeRegistered, teams);

            MembersJoinTeams(teams);
            SortTeamsAndPrintOutput(teams);
        }

        static void SortTeamsAndPrintOutput(List<Team> teams)
        {
            List<Team> teamsToDisband = teams.Where(x => x.Members.Count == 0)
                .OrderBy(n => n.TeamName)
                .ToList();

            List<Team> sortetTeams = teams.Where(x => x.Members.Count > 0)
                .OrderByDescending(c => c.Members.Count)
                .ThenBy(n => n.TeamName)
                .ToList();

            sortetTeams.ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }

        }

        static void MembersJoinTeams(List<Team> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command.Split("->").ToArray();
                string member = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (!(teams.Any(x => x.TeamName == teamName)))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teams.Any(x => x.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }
                if (teams.Any(c => c.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                int index = teams.FindIndex(x => x.TeamName == teamName);
                teams[index].AddMembersToList(member);
            }
        }

        static void RegisterTeams(int number, List<Team> teams)
        {
            for (int i = 0; i < number; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split("-").ToArray();
                string creator = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                if (teams.Any(tn => tn.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                Team team = new Team(creator, teamName);
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }
    }
}
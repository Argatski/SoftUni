using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public string Creator { get; set; }

        public string TeamName { get; set; }

        public List<string> Members;

        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        public void AddMembersToList(string member)
        {
            Members.Add(member);
        }

        public override string ToString()
        {
            Members = Members.OrderBy(x => x).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine();

            sb.AppendLine(this.TeamName);
            sb.AppendLine("- " + Creator);
            foreach (var member in Members)
            {
                sb.AppendLine("-- " + member);
            }

            return sb.ToString().Trim();
        }
    }
}
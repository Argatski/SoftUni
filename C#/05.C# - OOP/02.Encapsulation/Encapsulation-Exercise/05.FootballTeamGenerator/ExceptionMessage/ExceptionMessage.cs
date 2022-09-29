using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class ExceptionMessage
    {
        public static string invalidName = "A name should not be empty.";
        public static string invalidStats = "{0} should be between 0 and 100.";

        public static string missingPlayer = "Player {0} is not in {1} team.";
    }
}

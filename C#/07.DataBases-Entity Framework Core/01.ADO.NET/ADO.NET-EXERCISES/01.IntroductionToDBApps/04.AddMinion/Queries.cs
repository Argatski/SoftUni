using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AddMinion
{
    public class Queries
    {
        public const string TownId = @"SELECT Id FROM Towns WHERE [Name]=@townName";

        public const string VillainId = @"SELECT Id FROM Villains WHERE [Name]=@Name";

        public const string MinionId = @"SELECT Id FROM Minions WHERE [Name]=@Name";

        public const string InsertMinionsVillains = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@villainId,@minionId)";

        public const string InsertVillain = @"INSERT INTO Villains([NAME], EvilnessFactorId) VALUES (@villaiName, 4)";

        public const string InsertMinion = @"INSERT INTO Minions ([Name],Age, TownId) VALUES (@name,@age,@townId)";

        public const string InsertTown = @"INSERT INTO Towns ([Name]) VALUES (@townName)";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinionNames
{
   public class Queries
    {
        public const string VillainName = @"SELECT [Name] FROM Villains WHERE Id=@Id";

        public const string MinionsNames =
            @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                       m.Name, 
                       m.Age FROM MinionsVIllains AS mv
            JOIN Minions AS m ON mv.MinionId = m.id WHERE mv.VillainId=@Id
            ORDER BY m.Name";
    }
}

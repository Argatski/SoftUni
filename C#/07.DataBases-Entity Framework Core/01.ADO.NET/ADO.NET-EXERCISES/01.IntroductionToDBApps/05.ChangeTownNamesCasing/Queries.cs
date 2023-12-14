using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChangeTownNamesCasing
{
    public class Queries
    {
        public const string namesQuery = @"SELECT t.[Name] FROM Towns AS t JOIN Countries AS c ON t.CountryCode=c.Id WHERE c.Name =@countryName";

        public const string updateQuery = @"UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";
    }
}

using _02.VillainNames;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;

internal class StartUp
{
    private static void Main(string[] args)
    {
        using (var connection =  new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            string selectQuery= "SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount " +
                    "FROM Villains AS v JOIN MinionsVillains AS mv ON v.Id = mv.VillainId " +
                    "GROUP BY v.Id, v.Name " +
                    "HAVING COUNT(mv.VillainId) > 3" +
                    "ORDER BY COUNT(mv.VillainId)";

            using (var command =  new SqlCommand(selectQuery,connection))
            {
                using (var dataRead = command.ExecuteReader())
                {
                    while (dataRead.Read())
                    {
                        Console.WriteLine($"{dataRead[0]} - {dataRead[1]}");
                    }
                }
            }

        }
    }
}
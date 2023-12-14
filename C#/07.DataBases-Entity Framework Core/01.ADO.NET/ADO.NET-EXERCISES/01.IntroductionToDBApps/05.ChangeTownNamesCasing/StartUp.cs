using _05.ChangeTownNamesCasing;
using Microsoft.Data.SqlClient;

internal class StartUp
{
    private static void Main(string[] args)
    {
        string countryName = Console.ReadLine();

        using (var connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            var rowsAffected = GetAffectedRows(connection, countryName);

            if (rowsAffected <= 0)
            {
                Console.WriteLine($"No town names were affected.");
                Environment.Exit(0);
            }

            Console.WriteLine($"{rowsAffected} town names were affected.");

            var townNames = GetTownsByName(connection, countryName);

            Console.WriteLine($"[{string.Join(", ",townNames)}");
        }
    }

    private static List<string> GetTownsByName(SqlConnection connection, string? countryName)
    {
        var list = new List<string>();

        using (var command = new SqlCommand(Queries.namesQuery,connection))
        {
            command.Parameters.AddWithValue("@countryName", countryName);

            using (var dataReader =  command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    string town = (string)dataReader[0];
                    list.Add(town);
                }
            }
        }

        return list;
    }

    private static int GetAffectedRows(SqlConnection connection, string? countryName)
    {
        using (var command = new SqlCommand(Queries.updateQuery, connection))
        {
            command.Parameters.AddWithValue("@countryName", countryName);

            return command.ExecuteNonQuery();
        }
    }
}
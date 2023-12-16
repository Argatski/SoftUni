using _08.IncreaseMinionAge;
using Microsoft.Data.SqlClient;

internal class StartUp
{
    private static void Main(string[] args)
    {
        int[] ids = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


        using (SqlConnection connection = new SqlConnection(Configurate.ConnectionString))
        {
            connection.Open();

            foreach(int id in ids)
            {
                UpdateMinionsById(id, connection);
            }

            PrintAllMinions(connection);
        }
    }

    private static void PrintAllMinions(SqlConnection connection)
    {
        using (SqlCommand command =  new SqlCommand(Queries.SelectNameAge,connection))
        {
            using (var dataReader =  command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    var minonName = (string)dataReader[0];
                    var minonAge = (int)dataReader[1];

                    Console.WriteLine($"{minonName} {minonAge}");
                }
            }
        }
    }

    private static void UpdateMinionsById(int id, SqlConnection connection)
    {
        using (SqlCommand command =  new SqlCommand(Queries.UpdateMinionById,connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
}
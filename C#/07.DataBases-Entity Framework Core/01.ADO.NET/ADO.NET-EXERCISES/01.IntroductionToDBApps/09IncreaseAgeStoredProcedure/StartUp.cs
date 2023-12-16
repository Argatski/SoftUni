using _09IncreaseAgeStoredProcedure;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {
       int id =  int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();

            CreateProcedure(connection);

            ExecutProcedure(id, connection);

            PrintMinionById(id, connection);
        }
    }

    private static void PrintMinionById(int id, SqlConnection connection)
    {
        using (var command = new SqlCommand(Queries.SelectMinionById, connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader()) 
            {
                while (reader.Read()) 
                {
                    var minionName = (string)reader[0];
                    var minonAge = (int)reader[1];

                    Console.WriteLine($"{minionName} - {minonAge} years old");
                }
            }
        }

    }

    private static void ExecutProcedure(int id, SqlConnection connection)
    {
        using (SqlCommand command = new SqlCommand(Queries.ExecuteProcedure,connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }

    private static void CreateProcedure(SqlConnection connection)
    {
        using (SqlCommand command =  new SqlCommand(Queries.CreateGetOlderProcedure,connection))
        {
            command.ExecuteNonQuery();
        }
    }
}
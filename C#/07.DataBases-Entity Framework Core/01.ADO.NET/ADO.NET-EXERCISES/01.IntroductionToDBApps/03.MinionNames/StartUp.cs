using _03.MinionNames;
using Microsoft.Data.SqlClient;

internal class Startup
{
    private static void Main(string[] args)
    {
        //Read Id
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
        {
            connection.Open();


            using (var command = new SqlCommand(Queries.VillainName, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                string villainName = (string)command.ExecuteScalar();

                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {id} exists in the database.");
                    return;
                }

                Console.WriteLine($"Villain: {villainName}");
            }

            using (SqlCommand command = new SqlCommand(Queries.MinionsNames, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("(no minions)");
                        return;
                    }
                    while (reader.Read())
                    {
                        var rowNum = (long)reader[0];
                        var name = (string)reader[1];
                        var age = (int)reader[2];

                        Console.WriteLine($"{rowNum}. {name} {age}");
                    }
                }


                /*
                VillainNameOutput(id, connection);

                MinnionsNamesOutput(id, connection);*/

            }



    }
    /*
    private static void MinnionsNamesOutput(int id, SqlConnection connection)
    {
        using (SqlCommand command = new SqlCommand(Queries.MinionsNames, connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    Console.WriteLine("(no minions)");
                    return;
                }
                while (reader.Read()) 
                {
                    var rowNum = (long)reader[0];
                    var name= (string)reader[1];
                    var age = (int)reader[2];

                    Console.WriteLine($"{rowNum}. {name} {age}");
                }
            }
        }
    }

    private static void VillainNameOutput(int id, SqlConnection connection)
    {
        using (var command = new SqlCommand(Queries.VillainName, connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            string villainName = (string)command.ExecuteScalar();

            if (villainName == null)
            {
                Console.WriteLine($"No villain with ID {id} exists in the database.");
                return;
            }

            Console.WriteLine($"Villain: {villainName}");
        }*/
    }
}
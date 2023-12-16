using _07.PrintAllMinionNames;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

internal class StartUp
{
    private static void Main(string[] args)
    {
        using (SqlConnection connection =  new SqlConnection(Configurate.ConnectionString))
        {
            connection.Open();

            //Get all minion names in list
            var minionNames = GetAllMinionNames(connection);


            //Console.WriteLine(string.Join(", ",minionNames));

            PrintAllMinnionNames(minionNames);

        }
    }

    private static void PrintAllMinnionNames(List<string> minionNames)
    {
       if (minionNames.Count >0)
        {
            for (int i = 0; i < minionNames.Count/2; i++)
            {
                Console.WriteLine(minionNames[i]);
                Console.WriteLine(minionNames[minionNames.Count - 1 - i]);
            }
            if (minionNames.Count % 2 != 0)
            {
                Console.WriteLine(minionNames[minionNames.Count / 2]);
            }
        }
    }

    private static List<string> GetAllMinionNames(SqlConnection connection)
    {
        var list =  new List<string>();


        using(SqlCommand command = new SqlCommand(Query.selectMinonNames, connection)) 
        {
            using (var dataReader =  command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    var name = (string)dataReader[0];

                    list.Add(name);
                }
            }
        }

        return list;
    }
}
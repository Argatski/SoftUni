using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;

internal class Program
{
    private const string connectionString = @"Server=DESKTOP-P22IBOP\MSSQLSERVER_2023;Database=SoftUni;Integrated Security=True;TrustServerCertificate=true";
    private static void Main(string[] args)
    {
        using (SqlConnection connnect= new SqlConnection(connectionString))
        {
            connnect.Open();

            //Command
            string command = @"SELECT [FirstName], [LastName] FROM Employees
            WHERE FirstName LIKE 'N%'";

            SqlCommand cmd = new SqlCommand(command, connnect);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string firstName = (string)reader[0];
                    string lastName = (string)reader[1];

                    Console.WriteLine(firstName + " " + lastName);

                }
            } 

        }
    }
}
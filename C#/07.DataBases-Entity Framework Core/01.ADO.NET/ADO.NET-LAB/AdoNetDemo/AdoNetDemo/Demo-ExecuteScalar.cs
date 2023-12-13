using Microsoft.Data.SqlClient;

internal class Demo
{
    // .
    // localhost 127.0.0.
    // DESKTOP-P22IBOP
    //Connect with server
    private const string connectionString = @"Server=DESKTOP-P22IBOP\MSSQLSERVER_2023;Database=SoftUni;Integrated Security=True;TrustServerCertificate=true";

   
    private static void Main(string[] args)
    {

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            //Open connection
            connection.Open();
            
            //Command to database
            string command = @"SELECT COUNT(*) FROM Employees";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            int result = (int)sqlCommand.ExecuteScalar();//USE WHEN WE HAVE ONE CELL

            Console.WriteLine(result);

        }
    }
}

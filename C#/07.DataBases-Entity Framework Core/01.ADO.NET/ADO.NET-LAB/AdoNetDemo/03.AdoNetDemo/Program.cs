using Microsoft.Data.SqlClient;

internal class Program
{
    private const string connection = @"Server=DESKTOP-P22IBOP\MSSQLSERVER_2023;Database=SoftUni;Integrated Security=True;TrustServerCertificate=true";

    private static void Main(string[] args)
    {
        using (SqlConnection  sqlConnection = new SqlConnection(connection))
        {
            sqlConnection.Open();

            //Command
            string command = @"SELECT [FirstName],[LastName],[Salary] FROM Employees WHERE FirstName LIKE 'N%'";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);

            //Read
            

            ReaderSQL(cmd);


            //Update salary
            SqlCommand updCmd = new SqlCommand("UPDATE Employees SET Salary = Salary * 1.10",sqlConnection);

            int updateRows = updCmd.ExecuteNonQuery();

            Console.WriteLine(updateRows);

            ReaderSQL(cmd);
          

        }
        
    }

    private static void ReaderSQL(SqlCommand cmd)
    {
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                string firstName = (string)reader[0];
                string lastName = (string)reader[1];
                decimal salary = (decimal)reader[2];

                Console.WriteLine(firstName + " " + lastName + " " + salary);
            }

        }
    }
}
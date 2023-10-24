using System.Data.SqlClient;

namespace adoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";

            using(SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = connectionString;

                connect.Open();

                int findId = 1;

                string query = $"select * from UserTable";

                SqlCommand sqlCommand = new SqlCommand(query, connect);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["userId"]} {reader["firstName"]} {reader["lastName"]}");
                    }
                }
            }
        }
    }
}
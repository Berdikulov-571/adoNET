using System.Data.SqlClient;

namespace adoNET
{
    public class DataContextAdoNet
    {
        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="userId"></param>
        public static void GetById(int userId)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"select * from userTable where userId = {userId}";

                SqlCommand command = new SqlCommand(query, connection);

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader["userId"]} {reader["firstName"]} {reader["lastName"]}");
                    }
                }
            }
        }

        /// <summary>
        /// Get All
        /// </summary>
        public static void GetAll()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";

            using(SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = "select * from userTable";

                SqlCommand command = new SqlCommand(@query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader["userId"]} {reader["firstName"]} {reader["lastName"]}");
                    }
                }
            }
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="userId"></param>
        public static void DeleteById(int userId)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"delete from userTable where userId = {userId}";

                SqlCommand command = new SqlCommand(query , connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                }
            }
        }

        /// <summary>
        /// Create new User
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public static void Create(int userId,string firstName,string lastName)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";
            
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"insert into userTable(userId,firstName,lastName) values({userId}, '{firstName}', '{lastName}')";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader()) { }
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public static void Update(int userId, string firstName, string lastName)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"update userTable set firstName = '{firstName}',lastName = '{lastName}' where userId = {userId};";

                SqlCommand command = new SqlCommand(query,connection);

                using(SqlDataReader reader = command.ExecuteReader()) { }
            }
        }

        /// <summary>
        /// This Function Return List<User>
        /// </summary>
        /// <returns></returns>
        public static List<User> GetUsers()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";

            List<User> users = new List<User>();

            using(SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = "select * from userTable";

                SqlCommand command = new SqlCommand(query,connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            userId = (int)reader[0],
                            firstName = (string)reader[1],
                            lastName = (string)reader[2]
                        });
                    }
                }

                return users;
            }
        }
    }
}

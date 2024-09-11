using CourseProject.Helper;
using System.Data.SqlClient;

namespace CourseProject.Repository
{
    public class UserRepository
    {
        public bool Login(string userName, string password)
        {
            string query = "select * from Users where Username = @userName and Password = @password";
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserHelper.Role = reader["Role"].ToString();
                                UserHelper.Username = reader["Username"].ToString();
                            }
                            return true;
                            
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

        }
    }
}

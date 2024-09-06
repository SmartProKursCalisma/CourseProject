using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Repository
{
    public class UserRepository
    {
        private string _connectionString;
        public UserRepository()
        {
            _connectionString = "Server=202-00;Database=CourseProjectDb;User Id=sa;Password=1234;";
        }


        public bool Login(string userName, string password)
        {
            string query = "select * from Users where Username = @userName and Password = @password";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }

        }
    }
}

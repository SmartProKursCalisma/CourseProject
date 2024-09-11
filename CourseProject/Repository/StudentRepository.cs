using CourseProject.Entities;
using CourseProject.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Repository
{
    public class StudentRepository
    {   
        public List<Student>  StudentList()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                string query = "select * from Students";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Student student = new Student();
                                student.Id = Convert.ToInt32(reader["Id"]);
                                student.NameSurname = reader["Namesurname"].ToString();
                                student.PhoneNumber = reader["PhoneNumber"].ToString();
                                student.GradeId = Convert.ToInt32(reader["GradeId"]);
                                students.Add(student);

                            }
                            return students;
                        }
                        return students;
                    }
                }
            }
        }
    }
}

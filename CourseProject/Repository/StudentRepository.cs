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
        public List<Student> StudentList()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                string query = "select * from Students";
                using (SqlCommand command = new SqlCommand(query, connection))
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
        public int UpdateStudent(int id, string nameSurname, string phoneNumber,string gradeId)
        {
            using (SqlConnection _connection = new SqlConnection(DbHelper.ConnectionString))
            {
                _connection.Open();
                string query = "update Students set Namesurname = @nameSurname, Phonenumber = @phoneNumber,GradeId = @gradeId where Id = @id";
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nameSurname", nameSurname);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@gradeId", gradeId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
        public int AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                string query = "insert into Students(NameSurname,PhoneNumber,GradeId) values " +
                    "(@nameSurname,@phoneNumber,@gradeId)";
                using (SqlCommand command =new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@nameSurname",student.NameSurname);
                    command.Parameters.AddWithValue("@phoneNumber", student.PhoneNumber);
                    command.Parameters.AddWithValue("@gradeId", student.GradeId);
                    int affectedRows =  command.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }
        public int DeleteStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                string query = "delete Students where Id = @id";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@id",id);
                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }
    }
}

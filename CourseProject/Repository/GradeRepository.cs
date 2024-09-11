
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
    public class GradeRepository
    {
        public List<Grade> GradeList()
        {
            List<Grade> grades = new List<Grade>();
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                string query = "select * from Grades";
                using (SqlCommand command  = new SqlCommand(query,connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Grade grade = new Grade();
                            grade.Id = (int)reader["Id"];
                            grade.GradeName = (string)reader["GradeName"];
                            grades.Add(grade);
                        }
                        return grades;
                    }
                    
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Entities
{
    public class Student:BaseEntity
    {
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }
        public int GradeId { get; set; }
    }
}

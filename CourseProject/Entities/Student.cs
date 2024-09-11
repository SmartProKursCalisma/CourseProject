using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Entities
{
    public class Student:BaseEntity
    {
        [DisplayName("Öğrenci Adı")]
        public string NameSurname { get; set; }
        [DisplayName("İletişim No")]
        public string PhoneNumber { get; set; }
        [Browsable(false)]
        public int GradeId { get; set; }
    }
}

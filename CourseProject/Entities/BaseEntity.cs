using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Entities
{
    public class BaseEntity
    {
        [DisplayName("Sıra No")]
        public int Id { get; set; }
    }
}

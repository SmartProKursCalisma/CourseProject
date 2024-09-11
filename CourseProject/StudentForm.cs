using CourseProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class StudentForm : Form
    {
        private readonly StudentRepository _studentRepository; 
        public StudentForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _studentRepository.StudentList();
            dataGridView1.Columns["Id"].DisplayIndex = 0;
        }
    }
}

using CourseProject.Entities;
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
    public partial class NewStudentForm : Form
    {
        private readonly GradeRepository _gradeRepository;
        private readonly StudentRepository _studentRepository;
        DataGridView _gridView;
        public NewStudentForm(DataGridView grid)
        {
            InitializeComponent();
            _gradeRepository = new GradeRepository();
            _studentRepository = new StudentRepository();
            _gridView = grid;
        }

        private void NewStudentForm_Load(object sender, EventArgs e)
        {
            cmbGrades.DataSource = _gradeRepository.GradeList();
            cmbGrades.ValueMember = "Id";
            cmbGrades.DisplayMember = "GradeName";
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                NameSurname = txtStudentName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                GradeId = Convert.ToInt32(cmbGrades.SelectedValue)
            };
            int Affected = _studentRepository.AddStudent(student);
            if (Affected > 0)
            {
                MessageBox.Show("Öğrenci Eklendi.");
                StudentListView();
            }
        }
        private void StudentListView()
        {
            _gridView.DataSource = _studentRepository.StudentList();
            _gridView.Columns["Id"].DisplayIndex = 0;
        }
    }
}

using CourseProject.Entities;
using CourseProject.Helper;
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
        private readonly GradeRepository _gradeRepository;
        public StudentForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            _gradeRepository = new GradeRepository();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserHelper.Username;
            cmbGrades.DataSource = _gradeRepository.GradeList();
            cmbGrades.ValueMember = "Id";
            cmbGrades.DisplayMember = "GradeName";
            StudentListView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            var student = (Student)row.DataBoundItem;
            txtStudentName.Text = student.NameSurname;
            txtId.Text = student.Id.ToString();
            txtPhoneNumber.Text = student.PhoneNumber;
            cmbGrades.SelectedValue = student.GradeId;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int gradeId =Convert.ToInt32(cmbGrades.SelectedValue);
            int result = _studentRepository.UpdateStudent(int.Parse(txtId.Text), txtStudentName.Text, txtPhoneNumber.Text,gradeId.ToString());
            if (result > 0)
            {
                StudentListView();
                MessageBox.Show($"{result} Adet Kayıt Hareket Gördü.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kayıt Güncelleme İşlemi Başarısız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudentForm form = new NewStudentForm(dataGridView1);
            form.ShowDialog();
        }

        private void btnStudentListRefresh_Click(object sender, EventArgs e)
        {
            StudentListView();
        }
        private void StudentListView()
        {
            dataGridView1.DataSource = _studentRepository.StudentList();
            dataGridView1.Columns["Id"].DisplayIndex = 0;
        }
    }
}

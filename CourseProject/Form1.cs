﻿using CourseProject.Repository;
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
    public partial class Form1 : Form
    {
        private readonly UserRepository _userRepository;
        public Form1()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            bool isLogin = _userRepository
                .Login(userName,textBox2.Text);
            if (isLogin)
            {
                MessageBox.Show("Giriş Başarılı", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı.", "Bilgilendirme");
            }
        }
    }
}

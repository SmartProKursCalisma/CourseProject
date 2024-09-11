namespace CourseProject
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbGrades = new System.Windows.Forms.ComboBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnStudentListRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(581, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(41, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "label1";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(373, 56);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(373, 96);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İletişim Numarası";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(373, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Öğrenci Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(373, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 20);
            this.txtId.TabIndex = 8;
            // 
            // cmbGrades
            // 
            this.cmbGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrades.FormattingEnabled = true;
            this.cmbGrades.Location = new System.Drawing.Point(479, 56);
            this.cmbGrades.Name = "cmbGrades";
            this.cmbGrades.Size = new System.Drawing.Size(121, 21);
            this.cmbGrades.TabIndex = 9;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(479, 122);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(83, 34);
            this.btnNewStudent.TabIndex = 10;
            this.btnNewStudent.Text = "Yeni Öğrenci Formu";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnStudentListRefresh
            // 
            this.btnStudentListRefresh.Location = new System.Drawing.Point(568, 122);
            this.btnStudentListRefresh.Name = "btnStudentListRefresh";
            this.btnStudentListRefresh.Size = new System.Drawing.Size(69, 34);
            this.btnStudentListRefresh.TabIndex = 11;
            this.btnStudentListRefresh.Text = "Liste Güncelle";
            this.btnStudentListRefresh.UseVisualStyleBackColor = true;
            this.btnStudentListRefresh.Click += new System.EventHandler(this.btnStudentListRefresh_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 377);
            this.Controls.Add(this.btnStudentListRefresh);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.cmbGrades);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentForm";
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbGrades;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnStudentListRefresh;
    }
}
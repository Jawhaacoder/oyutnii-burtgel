namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode2 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode3 = new TreeNode("Программ хангамж");
            TreeNode treeNode4 = new TreeNode("Мэдээллийн технологийн сургууль", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            label1 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblAge = new Label();
            nudAge = new NumericUpDown();
            lblGender = new Label();
            cmbGender = new ComboBox();
            chkScholarship = new CheckBox();
            label3 = new Label();
            clbCourses = new CheckedListBox();
            label4 = new Label();
            lstLanguages = new ListBox();
            picStudent = new PictureBox();
            btnChoosePhoto = new Button();
            lblDepartment = new Label();
            tvDepartment = new TreeView();
            dgvStudents = new DataGridView();
            btnRegister = new Button();
            btnClear = new Button();
            lblTotal = new Label();
            rtbResult = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 0;
            label1.Text = "Оюутны код";
            label1.Click += label1_Click;
            // 
            // txtCode
            // 
            txtCode.AcceptsTab = true;
            txtCode.Location = new Point(154, 9);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(150, 34);
            txtCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "Овог нэр";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(154, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(150, 34);
            txtFullName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 105);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(49, 28);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "утас";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(145, 105);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 34);
            txtPhone.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(12, 179);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(140, 28);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Төрсөн огноо\r\n";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(154, 179);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(195, 34);
            dtpBirthDate.TabIndex = 7;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(12, 249);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(43, 28);
            lblAge.TabIndex = 9;
            lblAge.Text = "нас";
            // 
            // nudAge
            // 
            nudAge.Enabled = false;
            nudAge.Location = new Point(124, 247);
            nudAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.ReadOnly = true;
            nudAge.Size = new Size(180, 34);
            nudAge.TabIndex = 10;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(6, 324);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(55, 28);
            lblGender.TabIndex = 11;
            lblGender.Text = "Хүйс";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Эрэгтэй", "Эмэгтэй" });
            cmbGender.Location = new Point(122, 321);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 36);
            cmbGender.TabIndex = 12;
            // 
            // chkScholarship
            // 
            chkScholarship.AutoSize = true;
            chkScholarship.Location = new Point(26, 563);
            chkScholarship.Name = "chkScholarship";
            chkScholarship.Size = new Size(137, 32);
            chkScholarship.TabIndex = 13;
            chkScholarship.Text = "тэтгэлэгтэй";
            chkScholarship.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 411);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 14;
            label3.Text = "хичээл";
            label3.Click += label3_Click;
            // 
            // clbCourses
            // 
            clbCourses.CheckOnClick = true;
            clbCourses.FormattingEnabled = true;
            clbCourses.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            clbCourses.Location = new Point(124, 393);
            clbCourses.Name = "clbCourses";
            clbCourses.Size = new Size(213, 159);
            clbCourses.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 312);
            label4.Name = "label4";
            label4.Size = new Size(41, 28);
            label4.TabIndex = 16;
            label4.Text = "хэл";
            label4.Click += label4_Click;
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Япон", "Солонгос", "Хятад" });
            lstLanguages.Location = new Point(378, 363);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(180, 172);
            lstLanguages.TabIndex = 17;
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(378, 97);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(180, 180);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 18;
            picStudent.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Location = new Point(378, 12);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(180, 40);
            btnChoosePhoto.TabIndex = 19;
            btnChoosePhoto.Text = "\tЗураг сонгох";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(803, 567);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(76, 28);
            lblDepartment.TabIndex = 20;
            lblDepartment.Text = "тэнхим";
            // 
            // tvDepartment
            // 
            tvDepartment.HideSelection = false;
            tvDepartment.Location = new Point(607, 510);
            tvDepartment.Name = "tvDepartment";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Компьютерын ухаан";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Мэдээллийн технологи";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Программ хангамж";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Мэдээллийн технологийн сургууль";
            tvDepartment.Nodes.AddRange(new TreeNode[] { treeNode4 });
            tvDepartment.Size = new Size(450, 178);
            tvDepartment.TabIndex = 21;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(607, 101);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(450, 180);
            dgvStudents.TabIndex = 22;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(197, 567);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 40);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Бүртгэх";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(378, 555);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 24;
            btnClear.Text = "Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(682, 37);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 28);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Нийт: 0";
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(607, 292);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(450, 200);
            rtbResult.TabIndex = 26;
            rtbResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 788);
            Controls.Add(rtbResult);
            Controls.Add(lblTotal);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(dgvStudents);
            Controls.Add(tvDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(btnChoosePhoto);
            Controls.Add(picStudent);
            Controls.Add(lstLanguages);
            Controls.Add(label4);
            Controls.Add(clbCourses);
            Controls.Add(label3);
            Controls.Add(chkScholarship);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(nudAge);
            Controls.Add(lblAge);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "oyutnii burtgel";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCode;
        private Label label2;
        private TextBox txtFullName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblAge;
        private NumericUpDown nudAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private CheckBox chkScholarship;
        private Label label3;
        private CheckedListBox clbCourses;
        private Label label4;
        private ListBox lstLanguages;
        private PictureBox picStudent;
        private Button btnChoosePhoto;
        private Label lblDepartment;
        private TreeView tvDepartment;
        private DataGridView dgvStudents;
        private Button btnRegister;
        private Button btnClear;
        private Label lblTotal;
        private RichTextBox rtbResult;
    }
}

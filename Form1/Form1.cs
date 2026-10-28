using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Програм нээгдэхэд тохиргоог ажиллуулна.
            Load += SetupForm;
        }

        private void SetupForm(object sender, EventArgs e)
        {
            // Насны тохиргоо
            nudAge.Maximum = 150;
            nudAge.ReadOnly = true;
            nudAge.Enabled = false;

            // Төрсөн огнооны тохиргоо
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.MinDate = DateTime.Today.AddYears(-150);
            dtpBirthDate.MaxDate = DateTime.Today;

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPhone.MaxLength = 8;
            clbCourses.CheckOnClick = true;
            lstLanguages.SelectionMode = SelectionMode.One;

            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            rtbResult.ReadOnly = true;

            tvDepartment.HideSelection = false;
            tvDepartment.ExpandAll();

            // Хүснэгтийн баганууд
            dgvStudents.Columns.Clear();
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.MultiSelect = false;
            dgvStudents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvStudents.Columns.Add("Code", "Код");
            dgvStudents.Columns.Add("FullName", "Овог нэр");
            dgvStudents.Columns.Add("Phone", "Утас");
            dgvStudents.Columns.Add("Age", "Нас");

            // Товчнуудын үйлдэл
            btnChoosePhoto.Click += ChoosePhoto;
            btnRegister.Click += RegisterStudent;
            btnClear.Click += ClearInputs;

            dtpBirthDate.ValueChanged += BirthDateChanged;
            dgvStudents.CellClick += ShowStudentDetails;

            ResetInputs();
            lblTotal.Text = "Нийт: 0";
        }

        // Төрсөн огнооноос нас бодох
        private int CalculateAge()
        {
            DateTime birth = dtpBirthDate.Value.Date;
            DateTime today = DateTime.Today;

            int age = today.Year - birth.Year;

            if (birth > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void BirthDateChanged(object sender, EventArgs e)
        {
            nudAge.Value = CalculateAge();
        }

        // Компьютероос зураг сонгох
        private void ChoosePhoto(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Оюутны зураг сонгох";
                dialog.Filter =
                    "Зургийн файл|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (Image original =
                        Image.FromFile(dialog.FileName))
                    {
                        Image oldImage = picStudent.Image;
                        picStudent.Image = new Bitmap(original);
                        oldImage?.Dispose();
                    }
                }
                catch
                {
                    MessageBox.Show("Зургийг нээж чадсангүй.");
                }
            }
        }

        // Оюутан бүртгэх
        private void RegisterStudent(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (code == "" || fullName == "")
            {
                MessageBox.Show("Оюутны код, овог нэрээ оруулна уу.");
                return;
            }

            if (phone.Length != 8 ||
                !phone.All(c => c >= '0' && c <= '9'))
            {
                MessageBox.Show("Утасны дугаар 8 оронтой тоо байна.");
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Хүйсээ сонгоно уу.");
                return;
            }

            if (lstLanguages.SelectedIndex == -1)
            {
                MessageBox.Show("Хэлээ сонгоно уу.");
                return;
            }

            if (tvDepartment.SelectedNode == null ||
                tvDepartment.SelectedNode.Parent == null)
            {
                MessageBox.Show(
                    "Сургуулийн нэрийн доорх тэнхмээс сонгоно уу.");
                return;
            }

            // Оюутны код давхардсан эсэх
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                string existingCode =
                    Convert.ToString(row.Cells["Code"].Value);

                if (string.Equals(existingCode, code,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Энэ кодтой оюутан бүртгэлтэй байна.");
                    return;
                }
            }

            int age = CalculateAge();

            string gender = cmbGender.SelectedItem.ToString();
            string language = lstLanguages.SelectedItem.ToString();
            string department = tvDepartment.SelectedNode.Text;

            string scholarship =
                chkScholarship.Checked ? "Тийм" : "Үгүй";

            string courses = string.Join(", ",
                clbCourses.CheckedItems.Cast<object>());

            if (courses == "")
            {
                courses = "Сонгоогүй";
            }

            string details =
                $"Код: {code}\n" +
                $"Овог нэр: {fullName}\n" +
                $"Утас: {phone}\n" +
                $"Төрсөн огноо: {dtpBirthDate.Value:yyyy.MM.dd}\n" +
                $"Нас: {age}\n" +
                $"Хүйс: {gender}\n" +
                $"Тэтгэлэгтэй: {scholarship}\n" +
                $"Хичээл: {courses}\n" +
                $"Гадаад хэл: {language}\n" +
                $"Тэнхим: {department}";

            // Хүснэгтэд мөр нэмэх
            int index = dgvStudents.Rows.Add(
                code, fullName, phone, age);

            // Тухайн мөрөнд дэлгэрэнгүй мэдээллийг холбоно.
            dgvStudents.Rows[index].Tag = details;

            dgvStudents.ClearSelection();
            dgvStudents.Rows[index].Selected = true;

            rtbResult.Text = details;
            lblTotal.Text = "Нийт: " + dgvStudents.Rows.Count;

            MessageBox.Show("Амжилттай бүртгэгдлээ!");
        }

        // Хүснэгтийн мөр дарахад дэлгэрэнгүйг харуулах
        private void ShowStudentDetails(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            rtbResult.Text = Convert.ToString(
                dgvStudents.Rows[e.RowIndex].Tag);
        }

        private void ClearInputs(object sender, EventArgs e)
        {
            ResetInputs();
        }

        // Оруулах талбаруудыг цэвэрлэх
        private void ResetInputs()
        {
            txtCode.Clear();
            txtFullName.Clear();
            txtPhone.Clear();

            cmbGender.SelectedIndex = -1;
            lstLanguages.ClearSelected();
            chkScholarship.Checked = false;
            tvDepartment.SelectedNode = null;

            for (int i = 0; i < clbCourses.Items.Count; i++)
            {
                clbCourses.SetItemChecked(i, false);
            }

            dtpBirthDate.Value = DateTime.Today.AddYears(-20);
            nudAge.Value = CalculateAge();

            Image oldImage = picStudent.Image;
            picStudent.Image = null;
            oldImage?.Dispose();

            rtbResult.Clear();
            txtCode.Focus();
        }

        // Designer-тэй холбоотой өмнөх үйлдлүүд
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
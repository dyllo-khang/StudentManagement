

using BusinessObject;
using BusinessObject.Models;
using ManagementService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class ManagementStudent : Form
    {
        Account _account;
        private IStudentService _studentService;
        private IClassService _classService;
        public List<Student> _students;
        public List<Class> _classes;
        public ManagementStudent(Account account)
        {
            InitializeComponent();
            _account = account;
            _studentService = new StudentService();
            _classService = new ClassService();
            _students = _studentService.GetAll();
            _classes = _classService.GetAll();
        }

        public void LoadComboBox()
        {
            cbClass.DataSource = _classes;
            cbClass.DisplayMember = "ClassName";
            cbClass.ValueMember = "ClassId";
        }

        private void Reset()
        {
            txtID.Enabled = true;
            txtFullName.Text = string.Empty;
            rdMale.Checked = true;
            richAdress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbClass.SelectedIndex = 0;
        }
        private void ManagementStudent_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.DataSource = _students.Select(x => new
            {
                x.StudentId,
                x.FullName,
                BirthDay = x.DateOfBirth.ToString("MM-dd-yyyy"),
                x.Gender,
                x.Address,
                x.Email,
                x.ClassId,
                ClassName = x.Class.ClassName
            }
            ).ToList();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = dgvStudent.CurrentRow.Cells["StudentId"].Value.ToString();
            txtFullName.Text = dgvStudent.CurrentRow.Cells["FullName"].Value.ToString();
            string gender = dgvStudent.CurrentRow.Cells["Gender"].Value.ToString();
            if (gender == "male") rdMale.Checked = true;
            else rdFemale.Checked = true;
            string birthDay = dgvStudent.CurrentRow.Cells["BirthDay"].Value.ToString();
            DateTime parsedDate;
            if (DateTime.TryParseExact(birthDay, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                dtpBirthday.Value = parsedDate;
            }

            else MessageBox.Show("Can't parse string to DateTime", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            richAdress.Text = dgvStudent.CurrentRow.Cells["Address"].Value.ToString();
            txtEmail.Text = dgvStudent.CurrentRow.Cells["Email"].Value.ToString();
            string classID = dgvStudent.CurrentRow.Cells["ClassID"].Value.ToString();
            cbClass.SelectedIndex = _classes.IndexOf(_classes.SingleOrDefault(c => c.ClassId.Equals(classID)));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            _students = _studentService.GetAll(search);
            ManagementStudent_Load(this, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_account.Role == 1)
            {
                AddStudent addForm = new AddStudent(this);
                addForm.DataAdded += (s, data) =>
                {
                    try
                    {
                        _studentService.AddStudent(data);
                        MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    _students = _studentService.GetAll();
                    ManagementStudent_Load(this, e);
                };
                addForm.ShowDialog();
            }
            else MessageBox.Show("You aren't permision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_account.Role == 1)
            {
                string selectedId = txtID.Text;
                Student stu = _students.SingleOrDefault(s => s.StudentId.Equals(selectedId));
                if (stu != null)
                {
                    string resultFullName = ValidationHelper.ValidateFullName(txtFullName.Text.Trim());
                    if (resultFullName != null)
                    {
                        MessageBox.Show(resultFullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    stu.FullName = txtFullName.Text.Trim();
                    if (rdMale.Checked) stu.Gender = "male";
                    if (rdFemale.Checked) stu.Gender = "female";
                    if (string.IsNullOrWhiteSpace(richAdress.Text))
                    {
                        MessageBox.Show("Address cannot blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    stu.Address = richAdress.Text.Trim();
                    stu.DateOfBirth = dtpBirthday.Value;
                    string resultEmail = ValidationHelper.ValidateEmail(txtEmail.Text.Trim());
                    if (resultEmail != null)
                    {
                        MessageBox.Show(resultEmail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    stu.Email = txtEmail.Text.Trim();
                    stu.ClassId = cbClass.SelectedValue.ToString();
                    DialogResult result = MessageBox.Show("Are you sure to update", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (_studentService.UpdateStudent(stu))
                        {
                            _students = _studentService.GetAll();
                            ManagementStudent_Load(this, e);
                            MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK);
                            Reset();
                        }
                        else MessageBox.Show("Update failed: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else return;
                }
                else MessageBox.Show("Please select one row to update !!!", "Notification", MessageBoxButtons.OK);
            }
            else MessageBox.Show("You aren't permision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_account.Role == 1)
            {
                string selectedId = txtID.Text;
                if (!string.IsNullOrEmpty(selectedId))
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (_studentService.DeleteStudent(selectedId))
                        {
                            _students = _studentService.GetAll();
                            ManagementStudent_Load(this, e);
                            MessageBox.Show("The student and associated scores have been deleted!", "Notification", MessageBoxButtons.OK);
                            Reset();
                        }
                        else MessageBox.Show("Delete failed: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else return;
                }
                else MessageBox.Show("Please select one row to delete", "Notification", MessageBoxButtons.OK);
            }
            else MessageBox.Show("You aren't permision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ScoreDetail scoreDetail = new ScoreDetail();
            scoreDetail.ShowDialog();
        }
    }
}

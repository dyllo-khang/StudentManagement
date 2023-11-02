using BusinessObject;
using BusinessObject.Models;
using ManagementService;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class RegisterForm : Form
    {
        IAccountService _accountService;
        public RegisterForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Account account = _accountService.GetAll().SingleOrDefault(p => p.Email.Equals(email));
            if (account == null)
            {
                account = new Account();
                string resultFullName = ValidationHelper.ValidateFullName(txtFullName.Text.Trim());
                if (resultFullName != null)
                {
                    MessageBox.Show(resultFullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                account.FullName = txtFullName.Text.Trim();
                string resultEmail = ValidationHelper.ValidateEmail(txtEmail.Text.Trim());
                if (resultEmail != null)
                {
                    MessageBox.Show(resultEmail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                account.Email = txtEmail.Text.Trim();
                string resultPassword = ValidationHelper.ValidatePassword(txtPassword.Text.Trim());
                if (resultPassword != null)
                {
                    MessageBox.Show(resultPassword, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string passWord = txtPassword.Text.Trim();
                account.Password = passWord;
                account.Role = 2;
                if (!txtConfirm.Text.Trim().Equals(passWord))
                {
                    MessageBox.Show("Confirm password different password", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool add = _accountService.AddAccount(account);
                if (add)
                {
                    MessageBox.Show("Sign up successfully", "Notification", MessageBoxButtons.OK);
                    this.Close();
                }
                else MessageBox.Show("Sign up failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

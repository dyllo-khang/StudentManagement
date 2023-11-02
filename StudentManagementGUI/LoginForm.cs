

using BusinessObject.Models;
using ManagementService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class LoginForm : Form
    {
        IAccountService _accountService;
        public LoginForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = _accountService.GetAccount(txtEmail.Text, txtPassword.Text);
            if (account != null)
            {
                ManagementStudent management = new ManagementStudent(account);
                this.Hide();
                management.Show();
            }
            else MessageBox.Show("Login false, email or password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}


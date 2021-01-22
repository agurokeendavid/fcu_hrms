using System;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var model = new UserModel()
            {
                Username = txtUserName.Text,
                Password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text
            };
            await UserRepository.InsertUserAsync(model);
            MessageBox.Show(@"User successfully created!", @"Success", MessageBoxButtons.OK);
            Close();
        }
    }
}

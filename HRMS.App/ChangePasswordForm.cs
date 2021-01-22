using System;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (await UserRepository.IsCurrentPasswordSame(GlobalVariables.Id, txtCurrentPassword.Text))
            {
                if (txtNewPassword.Text == txtVerifyNewPassword.Text)
                {
                    var model = new UserModel()
                    {
                        Id = GlobalVariables.Id,
                        Password = txtNewPassword.Text
                    };
                    await UserRepository.UpdatePasswordAsync(model);
                    MessageBox.Show(@"Password successfully updated!", @"Success", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show(@"New and Verify New Password is not the same!", @"Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(@"Current Password is invalid!", @"Error", MessageBoxButtons.OK);
            }
        }
    }
}

using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            var user = await UserRepository.GetUserAccountAsync(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                GlobalVariables.Id = user.Id;
                GlobalVariables.Username = user.Username;
                GlobalVariables.FirstName = user.FirstName;
                GlobalVariables.MiddleName = user.MiddleName;
                GlobalVariables.LastName = user.LastName;
                Close();
            }
            else
            {
                MessageBox.Show(@"Incorrect username/password!", @"Invalid Credentials",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, System.EventArgs e)
        {
            var frm = new AboutForm();
            frm.ShowDialog();
        }
    }
}

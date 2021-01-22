using System;
using System.Windows.Forms;
using HRMS.App.Employees;
using HRMS.App.EmployeeType;
using HRMS.App.Leave;
using HRMS.App.LeaveType;
using HRMS.App.Offices;
using HRMS.App.Positions;
using HRMS.App.Seminars;

namespace HRMS.App
{
    public partial class MainParentForm : Form
    {

        public MainParentForm()
        {
            InitializeComponent();
        }

        private void MainParentForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            var frm = new LoginForm();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            frm.ShowDialog();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CreateAccountForm();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ChangePasswordForm();
            frm.ShowDialog();
        }


        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListOfEmployeesForm();
            frm.ShowDialog();
        }

        private void manageEmployeeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListOfEmployeeTypeForm();
            frm.ShowDialog();
        }

        private void manageOfficesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new OfficesForm();
            frm.ShowDialog();
        }

        private void managePositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PositionsForm();
            frm.ShowDialog();
        }

        private void manageSeminarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListOfSeminarsForm();
            frm.ShowDialog();
        }

        private void manageEmployeesLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ListOfEmployeeLeaveForm();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var currentDateTime = DateTime.Now;
            tssCurrentDateTime.Text = currentDateTime.ToString("MMMM dd, yyyy hh:mm:ss");
        }


        private void manageLeaveTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new LeaveTypesForm();
            frm.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;
using HRMS.App.Helpers;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.Leave
{
    public partial class ApplyLeaveForm : Form
    {
        public ApplyLeaveForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var employee = await EmployeeRepository.GetEmployeeByEmployeeNoAsync(txtEmployeeNo.Text);
            if (employee != null)
            {
                int leaveTypeId = Convert.ToInt32(cmbLeaveType.SelectedValue);
                var leaveType = await LeaveTypeRepository.GetLeaveTypeAsync(leaveTypeId);
                var leaveCredits = (dtpTo.Value.Date.AddDays(1) - dtpFrom.Value.Date).TotalDays;
                var leaveCreditsValue = await LeaveRepository.GetLeaveCreditsAsync(employee.Id, leaveTypeId);
                if (leaveCreditsValue <= leaveType.LeaveCredits && leaveCredits <= leaveType.LeaveCredits - leaveCreditsValue)
                {
                    var model = new LeaveModel()
                    {
                        EmployeeId = employee.Id,
                        LeaveTypeId = leaveTypeId,
                        LeaveFrom = dtpFrom.Value.Date,
                        LeaveTo = dtpTo.Value.Date,
                        LeaveCredits = leaveCredits,
                        Reason = txtReason.Text
                    };
                    await LeaveRepository.InsertLeaveAsync(model);
                    await EmailHelper.SendEmailNotificationAsync(employee, cmbLeaveType.Text, dtpFrom.Value.Date, dtpTo.Value.Date);
                    MessageBox.Show(@"Leave successfully created!", @"Success", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show(@"No remaining leave credits!", @"Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(@"Employee No. Not Found!", @"Error", MessageBoxButtons.OK);
            }
        }

        private async void ApplyLeaveForm_Load(object sender, EventArgs e)
        {
            cmbLeaveType.Items.Clear();
            cmbLeaveType.DataSource = await LeaveTypeRepository.GetLeaveTypesAsync();
            cmbLeaveType.ValueMember = "Id";
            cmbLeaveType.DisplayMember = "LeaveType";
            cmbLeaveType.SelectedItem = null;
        }
    }
}

using System;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.LeaveType
{
    public partial class AddEditLeaveTypeForm : Form
    {
        private readonly int? _id;
        public AddEditLeaveTypeForm(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == @"Save")
            {
                var model = new LeaveTypeModel()
                {
                    LeaveType = txtLeaveType.Text,
                    LeaveCredits = Convert.ToInt32(txtLeaveCredits.Text)
                };
                await LeaveTypeRepository.InsertLeaveTypeAsync(model);
                MessageBox.Show(@"Leave Type successfully created!", @"Success", MessageBoxButtons.OK);
            }
            else
            {
                var model = new LeaveTypeModel()
                {
                    Id = Convert.ToInt32(_id),
                    LeaveType = txtLeaveType.Text,
                    LeaveCredits = Convert.ToInt32(txtLeaveCredits.Text)
                };
                await LeaveTypeRepository.UpdateLeaveTypeAsync(model);
                MessageBox.Show(@"Leave Type successfully updated!", @"Success", MessageBoxButtons.OK);
            }
            Close();
        }

        private async void AddEditLeaveTypeForm_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var leaveType = await LeaveTypeRepository.GetLeaveTypeAsync(Convert.ToInt32(_id));
                if (leaveType != null)
                {
                    txtLeaveType.Text = leaveType.LeaveType;
                    txtLeaveCredits.Text = leaveType.LeaveCredits.ToString();
                    btnSave.Text = @"Update";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

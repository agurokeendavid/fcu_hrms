using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App.Leave
{
    public partial class ListOfEmployeeLeaveForm : Form
    {
        public ListOfEmployeeLeaveForm()
        {
            InitializeComponent();
        }

        private async Task FillGridView(DataGridView gridView, string search)
        {
            gridView.DataSource = await BindEmployeesLeaveInDataTableAsync(search);
            gridView.AutoGenerateColumns = false;
        }

        private async Task<DataTable> BindEmployeesLeaveInDataTableAsync(string search)
        {
            var employeesLeave = await LeaveRepository.GetLeavesAsync(search);
            using (var dt = new DataTable())
            {
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("EmployeeId", typeof(int));
                dt.Columns.Add("EmployeeNo", typeof(string));
                dt.Columns.Add("LeaveTypeId", typeof(int));
                dt.Columns.Add("LeaveType", typeof(string));
                dt.Columns.Add("LeaveFrom", typeof(DateTime));
                dt.Columns.Add("LeaveTo", typeof(DateTime));
                dt.Columns.Add("Reason", typeof(string));

                foreach (var leave in employeesLeave)
                {
                    dt.Rows.Add(leave.Id, leave.EmployeeId, leave.Employee.EmployeeNo, leave.LeaveTypeId, leave.LeaveType.LeaveType, leave.LeaveFrom, leave.LeaveTo,
                        leave.Reason);
                }

                return dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ListOfEmployeeLeaveForm_Load(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords, txtSearch.Text);
        }

        private async void btnApplyLeave_Click(object sender, EventArgs e)
        {
            var frm = new ApplyLeaveForm();
            frm.ShowDialog();
            await FillGridView(dtgRecords, txtSearch.Text);

        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords, txtSearch.Text);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show($@"Do you want to delete {dtgRecords.CurrentRow.Cells[4].Value} record?", @"Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    await LeaveRepository.DeleteLeaveAsync(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                    MessageBox.Show(@"Record successfully deleted!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await FillGridView(dtgRecords, txtSearch.Text);
                }
            }
        }

        private async void dtgRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                int leaveTypeId = Convert.ToInt32(dtgRecords.CurrentRow.Cells[3].Value);
                var leaveType = await LeaveTypeRepository.GetLeaveTypeAsync(leaveTypeId);
                var leaveCredits = await LeaveRepository.GetLeaveCreditsAsync(Convert.ToInt32(dtgRecords.CurrentRow.Cells[1].Value),
                        leaveTypeId);
                lblRemainingLeaveCredits.Text = $@"Remaining Leave Credits: {leaveType.LeaveCredits - leaveCredits}";
            }
            
        }
    }
}

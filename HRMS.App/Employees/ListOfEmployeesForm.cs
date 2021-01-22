using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App.Employees
{
    public partial class ListOfEmployeesForm : Form
    {
        public ListOfEmployeesForm()
        {
            InitializeComponent();
        }

        private async Task FillGridView(DataGridView gridView, string search)
        {
            gridView.DataSource = await BindEmployeesInDataTableAsync(search);
            gridView.AutoGenerateColumns = false;
        }

        private async Task<DataTable> BindEmployeesInDataTableAsync(string search)
        {
            var employees = await EmployeeRepository.GetEmployeesAsync(search);
            using (var dt = new DataTable())
            {
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("EmployeeNo", typeof(string));
                dt.Columns.Add("FirstName", typeof(string));
                dt.Columns.Add("MiddleName", typeof(string));
                dt.Columns.Add("LastName", typeof(string));
                dt.Columns.Add("Gender", typeof(string));
                dt.Columns.Add("Dob", typeof(DateTime));
                dt.Columns.Add("EmployeeTypeName", typeof(string));
                dt.Columns.Add("OfficeName", typeof(string));
                dt.Columns.Add("PositionName", typeof(string));
                dt.Columns.Add("WorkStatusName", typeof(string));
                dt.Columns.Add("ResumePath", typeof(string));

                foreach (var employee in employees)
                    dt.Rows.Add(employee.Id, employee.EmployeeNo, employee.FirstName, employee.MiddleName,
                        employee.LastName, employee.Gender, employee.Dob, employee.EmployeeType.EmployeeTypeName,
                        employee.Office.OfficeName, employee.Position.PositionName, employee.WorkStatus.WorkStatusName, employee.ResumePath);
                return dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddEditEmployeeForm(null);
            frm.ShowDialog();
            await FillGridView(dtgRecords, txtSearch.Text);
        }

        private async void ListOfEmployeesForm_Load(object sender, EventArgs e)
        {
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
                DialogResult dialogResult =
                    MessageBox.Show(
                        $@"Do you want to delete {dtgRecords.CurrentRow.Cells[4].Value}, {dtgRecords.CurrentRow.Cells[2].Value} {dtgRecords.CurrentRow.Cells[3].Value} record?",
                        @"Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    await EmployeeRepository.DeleteEmployeeAsync(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                    MessageBox.Show(@"Record successfully deleted!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await FillGridView(dtgRecords, txtSearch.Text);
                }
            }
            
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                var frm = new AddEditEmployeeForm(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
                await FillGridView(dtgRecords, txtSearch.Text);
            }
        }

        private void btnViewResume_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                Process.Start(dtgRecords.CurrentRow.Cells[11].Value.ToString());
            }
        }
    }
}

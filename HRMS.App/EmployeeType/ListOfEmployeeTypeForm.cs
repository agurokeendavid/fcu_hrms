using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App.EmployeeType
{
    public partial class ListOfEmployeeTypeForm : Form
    {
        public ListOfEmployeeTypeForm()
        {
            InitializeComponent();
        }

        private async Task FillGridView(DataGridView gridView)
        {
            gridView.DataSource = await EmployeeTypeRepository.GetEmployeeTypesAsync();
            gridView.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ListOfEmployeeTypeForm_Load(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddEditEmployeeTypeForm(null);
            frm.ShowDialog();
            await FillGridView(dtgRecords);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                var frm = new AddEditEmployeeTypeForm(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
                await FillGridView(dtgRecords);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow  != null)
            {
                DialogResult dialogResult = MessageBox.Show($@"Do you want to delete {dtgRecords.CurrentRow.Cells[1].Value} record?", @"Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    await EmployeeTypeRepository.DeleteEmployeeTypeAsync(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                    MessageBox.Show(@"Record successfully deleted!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await FillGridView(dtgRecords);
                }
            }
        }
    }
}

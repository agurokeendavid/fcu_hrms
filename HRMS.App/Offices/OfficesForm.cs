using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App.Offices
{
    public partial class OfficesForm : Form
    {
        public OfficesForm()
        {
            InitializeComponent();
        }

        private async Task FillGridView(DataGridView gridView)
        {
            gridView.DataSource = await OfficeRepository.GetOfficesAsync();
            gridView.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddEditOfficeForm(null);
            frm.ShowDialog();
            await FillGridView(dtgRecords);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                var frm = new AddEditOfficeForm(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
                await FillGridView(dtgRecords);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show($@"Do you want to delete {dtgRecords.CurrentRow.Cells[1].Value} record?", @"Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    await OfficeRepository.DeleteOfficeAsync(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                    MessageBox.Show(@"Record successfully deleted!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await FillGridView(dtgRecords);
                }
            }
        }

        private async void OfficesForm_Load(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords);
        }
    }
}

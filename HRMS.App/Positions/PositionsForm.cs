using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App.Positions
{
    public partial class PositionsForm : Form
    {
        public PositionsForm()
        {
            InitializeComponent();
        }

        private async Task FillGridView(DataGridView gridView)
        {
            gridView.DataSource = await PositionRepository.GetPositionsAsync();
            gridView.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddEditPositionForm(null);
            frm.ShowDialog();
            await FillGridView(dtgRecords);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                var frm = new AddEditPositionForm(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
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
                    await PositionRepository.DeletePositionAsync(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                    MessageBox.Show(@"Record successfully deleted!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await FillGridView(dtgRecords);
                }
            }
        }

        private async void PositionsForm_Load(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords);
        }
    }
}

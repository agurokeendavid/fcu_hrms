using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.CL.Repositories;

namespace HRMS.App.Seminars
{
    public partial class ListOfSeminarsForm : Form
    {
        public ListOfSeminarsForm()
        {
            InitializeComponent();
        }

        private async Task FillGridView(DataGridView gridView, string search)
        {
            gridView.DataSource = await BindSeminarsInDataTableAsync(search);
            gridView.AutoGenerateColumns = false;
        }

        private void CalculatePoints()
        {
            double total = 0;
            for (int i = 0; i < dtgRecords.Rows.Count; i++)
            {
                total += (int)dtgRecords.Rows[i].Cells[4].Value;
            }

            lblPoints.Text = $@"Total Points: {total}";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddEditSeminarForm(null);
            frm.ShowDialog();
            await FillGridView(dtgRecords, txtSearch.Text);
            CalculatePoints();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ListOfSeminarsForm_Load(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords, txtSearch.Text);
            CalculatePoints();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private async Task<DataTable> BindSeminarsInDataTableAsync(string search)
        {
            var seminars = await SeminarRepository.GetSeminarsAsync(search);
            using (var dt = new DataTable())
            {
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("EmployeeNo", typeof(string));
                dt.Columns.Add("SeminarName", typeof(string));
                dt.Columns.Add("SeminarLevelName", typeof(string));
                dt.Columns.Add("Points", typeof(int));
                dt.Columns.Add("CertificatePath", typeof(string));

                foreach (var seminar in seminars)
                    dt.Rows.Add(seminar.Id, seminar.Employee.EmployeeNo, seminar.SeminarName,
                        seminar.SeminarLevel.SeminarLevelName, seminar.SeminarLevel.Points, seminar.CertificatePath);

                return dt;
            }
        }

        private void btnViewCertificate_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                Process.Start(dtgRecords.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show($@"Do you want to delete {dtgRecords.CurrentRow.Cells[2].Value} record?", @"Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    await SeminarRepository.DeleteSeminarAsync((int)dtgRecords.CurrentRow.Cells[0].Value);
                    MessageBox.Show(@"Record successfully deleted!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    await FillGridView(dtgRecords, txtSearch.Text);
                    CalculatePoints();
                }
            }

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgRecords.CurrentRow != null)
            {
                var frm = new AddEditSeminarForm(Convert.ToInt32(dtgRecords.CurrentRow.Cells[0].Value));
                frm.ShowDialog();
                await FillGridView(dtgRecords, txtSearch.Text);
                CalculatePoints();
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await FillGridView(dtgRecords, txtSearch.Text);
            CalculatePoints();
        }
    }
}

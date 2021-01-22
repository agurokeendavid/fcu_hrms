using System;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.Offices
{
    public partial class AddEditOfficeForm : Form
    {
        private readonly int? _id;
        public AddEditOfficeForm(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void AddEditOfficeForm_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var office = await OfficeRepository.GetOfficeAsync(Convert.ToInt32(_id));
                if (office != null)
                {
                    txtOfficeName.Text = office.OfficeName;
                    btnSave.Text = @"Update";
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == @"Save")
            {
                var model = new OfficeModel()
                {
                    OfficeName = txtOfficeName.Text
                };
                await OfficeRepository.InsertOfficeAsync(model);
                MessageBox.Show(@"Record successfully saved!", @"Success", MessageBoxButtons.OK);
            }
            else
            {
                var model = new OfficeModel()
                {
                    Id = Convert.ToInt32(_id),
                    OfficeName = txtOfficeName.Text
                };
                await OfficeRepository.UpdateOfficeAsync(model);
                MessageBox.Show(@"Record successfully updated!", @"Success", MessageBoxButtons.OK);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

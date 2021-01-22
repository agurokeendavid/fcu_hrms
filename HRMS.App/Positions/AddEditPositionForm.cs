using System;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.Positions
{
    public partial class AddEditPositionForm : Form
    {
        private readonly int? _id;
        public AddEditPositionForm(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == @"Save")
            {
                var model = new PositionModel()
                {
                    PositionName = txtPositionName.Text
                };
                await PositionRepository.InsertPositionAsync(model);
                MessageBox.Show(@"Record successfully saved!", @"Success", MessageBoxButtons.OK);
            }
            else
            {
                var model = new PositionModel()
                {
                    Id = Convert.ToInt32(_id),
                    PositionName = txtPositionName.Text
                };
                await PositionRepository.UpdatePositionAsync(model);
                MessageBox.Show(@"Record successfully updated!", @"Success", MessageBoxButtons.OK);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddEditPositionForm_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var position = await PositionRepository.GetPositionAsync(Convert.ToInt32(_id));
                txtPositionName.Text = position.PositionName;
                btnSave.Text = @"Update";
            }
        }
    }
}

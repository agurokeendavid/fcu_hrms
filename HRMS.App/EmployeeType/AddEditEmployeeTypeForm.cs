using System;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.EmployeeType
{
    public partial class AddEditEmployeeTypeForm : Form
    {
        private readonly int? _id;
        public AddEditEmployeeTypeForm(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void AddEditEmployeeTypeForm_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var employeeType = await EmployeeTypeRepository.GetEmployeeTypeAsync(Convert.ToInt32(_id));
                if (employeeType != null)
                {
                    txtEmployeeTypeName.Text = employeeType.EmployeeTypeName;
                    btnSave.Text = @"Update";
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == @"Save")
            {
                var model = new EmployeeTypeModel()
                {
                    EmployeeTypeName = txtEmployeeTypeName.Text
                };

                await EmployeeTypeRepository.InsertEmployeeTypeAsync(model);
                MessageBox.Show(@"Record successfully saved!", @"Success", MessageBoxButtons.OK);
            }
            else
            {
                var model = new EmployeeTypeModel()
                {
                    Id = Convert.ToInt32(_id),
                    EmployeeTypeName = txtEmployeeTypeName.Text
                };
                await EmployeeTypeRepository.UpdateEmployeeTypeAsync(model);
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

using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.Employees
{
    public partial class AddEditEmployeeForm : Form
    {
        private readonly BackgroundWorker _worker = new BackgroundWorker();
        private string _source, _destination;
        private readonly int? _id;

        public AddEditEmployeeForm(int? id)
        {
            InitializeComponent();
            _worker.WorkerSupportsCancellation = true;
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += Worker_DoWork;
            _id = id;
        }

        private void CopyFile(string src, string des)
        {
            var fsout = new FileStream(des, FileMode.Create);
            var fsin = new FileStream(src, FileMode.Open);
            byte[] bt = new byte[1048756];

            int readByte;

            while ((readByte = fsin.Read(bt, 0, bt.Length)) > 0)
            {
                fsout.Write(bt, 0, readByte);
                _worker.ReportProgress((int)(fsin.Position * 100 / fsin.Length));
            }

            fsin.Close();
            fsout.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(_source, _destination);
        }

        private async void AddEditEmployeeForm_Load(object sender, EventArgs e)
        {
            cmbEmployeeType.Items.Clear();
            cmbEmployeeType.DataSource = await EmployeeTypeRepository.GetEmployeeTypesAsync();
            cmbEmployeeType.ValueMember = "Id";
            cmbEmployeeType.DisplayMember = "EmployeeTypeName";
            cmbEmployeeType.SelectedItem = null;

            cmbOffice.Items.Clear();
            cmbOffice.DataSource = await OfficeRepository.GetOfficesAsync();
            cmbOffice.ValueMember = "Id";
            cmbOffice.DisplayMember = "OfficeName";
            cmbOffice.SelectedItem = null;

            cmbPosition.Items.Clear();
            cmbPosition.DataSource = await PositionRepository.GetPositionsAsync();
            cmbPosition.ValueMember = "Id";
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.SelectedItem = null;

            cmbWorkStatus.Items.Clear();
            cmbWorkStatus.DataSource = await WorkStatusRepository.GetWorkStatusAsync();
            cmbWorkStatus.ValueMember = "Id";
            cmbWorkStatus.DisplayMember = "WorkStatusName";
            cmbWorkStatus.SelectedItem = null;

            if (_id != null)
            {
                var employee = await EmployeeRepository.GetEmployeeAsync(Convert.ToInt32(_id));
                if (employee != null)
                {
                    txtEmployeeNo.Text = employee.EmployeeNo;
                    txtFirstName.Text = employee.FirstName;
                    txtMiddleName.Text = employee.MiddleName;
                    txtLastName.Text = employee.LastName;
                    txtAddress.Text = employee.Address;
                    cmbGender.SelectedItem = employee.Gender;
                    dtpDateofBirth.Value = employee.Dob;
                    txtPlaceofBirth.Text = employee.PlaceOfBirth;
                    txtContactNo.Text = employee.ContactNo;
                    txtEmailAddress.Text = employee.EmailAddress;
                    cmbCivilStatus.SelectedItem = employee.CivilStatus;
                    cmbEmployeeType.SelectedValue = employee.EmployeeTypeId;
                    cmbOffice.SelectedValue = employee.OfficeId;
                    cmbPosition.SelectedValue = employee.PositionId;
                    cmbWorkStatus.SelectedValue = employee.WorkStatusId;
                    cmbHighestDegree.SelectedItem = employee.HighestDegree;
                    txtAcquiredDegree.Text = employee.AcquiredDegree;
                    txtWorkExperience.Text = employee.WorkExperience;
                    string path = employee.ResumePath;
                    lblFileName.Text = path;
                    _destination = path;
                }
                btnSave.Text = @"Update";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == @"Save")
            {
                var model = new EmployeeModel()
                {
                    EmployeeNo = txtEmployeeNo.Text,
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    Gender = cmbGender.SelectedItem.ToString(),
                    Dob = dtpDateofBirth.Value.Date,
                    PlaceOfBirth = txtPlaceofBirth.Text,
                    ContactNo = txtContactNo.Text,
                    EmailAddress = txtEmailAddress.Text,
                    CivilStatus = cmbCivilStatus.SelectedItem.ToString(),
                    EmployeeTypeId = Convert.ToInt32(cmbEmployeeType.SelectedValue),
                    OfficeId = Convert.ToInt32(cmbOffice.SelectedValue),
                    PositionId = Convert.ToInt32(cmbPosition.SelectedValue),
                    WorkStatusId = Convert.ToInt32(cmbWorkStatus.SelectedValue),
                    HighestDegree = cmbHighestDegree.SelectedItem.ToString(),
                    AcquiredDegree = txtAcquiredDegree.Text,
                    WorkExperience = txtWorkExperience.Text,
                    ResumePath = _destination
                };
                _worker.RunWorkerAsync();
                await EmployeeRepository.InsertEmployeeAsync(model);
                MessageBox.Show(@"Record successfully saved!", @"Success", MessageBoxButtons.OK);
            }
            else
            {
                var model = new EmployeeModel()
                {
                    Id = Convert.ToInt32(_id),
                    EmployeeNo = txtEmployeeNo.Text,
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    Gender = cmbGender.SelectedItem.ToString(),
                    Dob = dtpDateofBirth.Value.Date,
                    PlaceOfBirth = txtPlaceofBirth.Text,
                    ContactNo = txtContactNo.Text,
                    EmailAddress = txtEmailAddress.Text,
                    CivilStatus = cmbCivilStatus.SelectedItem.ToString(),
                    EmployeeTypeId = Convert.ToInt32(cmbEmployeeType.SelectedValue),
                    OfficeId = Convert.ToInt32(cmbOffice.SelectedValue),
                    PositionId = Convert.ToInt32(cmbPosition.SelectedValue),
                    WorkStatusId = Convert.ToInt32(cmbWorkStatus.SelectedValue),
                    HighestDegree = cmbHighestDegree.SelectedItem.ToString(),
                    AcquiredDegree = txtAcquiredDegree.Text,
                    WorkExperience = txtWorkExperience.Text,
                    ResumePath = _destination
                };
                if (_source != null)
                {
                    _worker.RunWorkerAsync();
                }
                await EmployeeRepository.UpdateEmployeeAsync(model);
                MessageBox.Show(@"Record successfully updated!", @"Success", MessageBoxButtons.OK);
            }
            Close();
        }

        private void btnAttachResume_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Title = @"Select a word document to be upload.";
                openFileDialog.Filter = @"Select File(*.doc; *.docx;; *.pdf)|*.doc;*.docx;*.pdf;";
                openFileDialog.FilterIndex = 1;
                openFileDialog.FileName = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _source = openFileDialog.FileName;
                    _destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Files\Resume\" +
                                  $@"{txtEmployeeNo.Text}-Resume{DateTime.Now.ToString("MMddyyyyhhmmssff", CultureInfo.InvariantCulture)}{Path.GetExtension(openFileDialog.SafeFileName)}";
                    lblFileName.Text = _source;
                }
            }
        }
    }
}

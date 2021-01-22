using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using HRMS.CL.Models;
using HRMS.CL.Repositories;

namespace HRMS.App.Seminars
{
    public partial class AddEditSeminarForm : Form
    {
        private readonly int? _id;
        private readonly BackgroundWorker _worker = new BackgroundWorker();
        private string _source, _destination;
        public AddEditSeminarForm(int? id)
        {
            InitializeComponent();
            _id = id;
            _worker.WorkerSupportsCancellation = true;
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += Worker_DoWork;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == @"Save")
            {
                var employee = await EmployeeRepository.GetEmployeeByEmployeeNoAsync(txtEmployeeNo.Text);
                if (employee != null)
                {
                    var model = new SeminarModel()
                    {
                        EmployeeId = employee.Id,
                        SeminarName = txtSeminarName.Text,
                        SeminarLevelId = Convert.ToInt32(cmbSeminarLevel.SelectedValue),
                        CertificatePath = _destination
                    };
                    _worker.RunWorkerAsync();
                    await SeminarRepository.InsertSeminarAsync(model);
                    MessageBox.Show(@"Record successfully saved!", @"Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(@"Employee No. Not Found!", @"Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                var model = new SeminarModel()
                {
                    Id = Convert.ToInt32(_id),
                    SeminarName = txtSeminarName.Text,
                    SeminarLevelId = Convert.ToInt32(cmbSeminarLevel.SelectedValue),
                    CertificatePath = _destination
                };
                if (_source != null)
                {
                    _worker.RunWorkerAsync();
                }
                await SeminarRepository.UpdateSeminarAsync(model);
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
                    _destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Files\Certificates\" + $@"{txtEmployeeNo.Text}-Certificate{DateTime.Now.ToString("MMddyyyyhhmmssff", CultureInfo.InvariantCulture)}{Path.GetExtension(openFileDialog.SafeFileName)}";
                    lblFileName.Text = _source;
                }
            }
        }

        private async void AddEditSeminarForm_Load(object sender, EventArgs e)
        {
            cmbSeminarLevel.Items.Clear();
            cmbSeminarLevel.DataSource = await SeminarLevelRepository.GetSeminarLevelAsync();
            cmbSeminarLevel.ValueMember = "Id";
            cmbSeminarLevel.DisplayMember = "SeminarLevelName";
            cmbSeminarLevel.SelectedItem = null;
            if (_id != null)
            {
                var seminar = await SeminarRepository.GetSeminarAsync(Convert.ToInt32(_id));
                if (seminar != null)
                {
                    string path = seminar.CertificatePath;
                    txtEmployeeNo.Text = seminar.Employee.EmployeeNo;
                    txtSeminarName.Text = seminar.SeminarName;
                    cmbSeminarLevel.SelectedValue = seminar.SeminarLevelId;
                    lblFileName.Text = path;
                    _destination = path;
                }

                btnSave.Text = @"Update";
            }
        }
    }
}

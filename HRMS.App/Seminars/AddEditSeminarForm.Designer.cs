namespace HRMS.App.Seminars
{
    partial class AddEditSeminarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSeminarForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label9 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAttachResume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeminarName = new System.Windows.Forms.TextBox();
            this.cmbSeminarLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(12, 10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(378, 45);
            this.Panel1.TabIndex = 51;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Teal;
            this.Label9.Location = new System.Drawing.Point(135, 6);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(176, 29);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "ADD SEMINAR";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::HRMS.App.Properties.Resources.filamer_logo;
            this.PictureBox1.Location = new System.Drawing.Point(66, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(63, 37);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 47;
            this.PictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFileName);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.btnAttachResume);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSeminarName);
            this.panel2.Controls.Add(this.cmbSeminarLevel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmployeeNo);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 203);
            this.panel2.TabIndex = 52;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(130, 156);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 66;
            this.lblFileName.Text = "File Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(68, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 65;
            this.label21.Text = "Certificate:";
            // 
            // btnAttachResume
            // 
            this.btnAttachResume.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAttachResume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttachResume.BackgroundImage")));
            this.btnAttachResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAttachResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttachResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttachResume.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAttachResume.Location = new System.Drawing.Point(133, 110);
            this.btnAttachResume.Name = "btnAttachResume";
            this.btnAttachResume.Size = new System.Drawing.Size(102, 43);
            this.btnAttachResume.TabIndex = 3;
            this.btnAttachResume.Text = "&Attach Certificate";
            this.btnAttachResume.UseVisualStyleBackColor = false;
            this.btnAttachResume.Click += new System.EventHandler(this.btnAttachResume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seminar Name:";
            // 
            // txtSeminarName
            // 
            this.txtSeminarName.BackColor = System.Drawing.Color.White;
            this.txtSeminarName.Location = new System.Drawing.Point(133, 57);
            this.txtSeminarName.Name = "txtSeminarName";
            this.txtSeminarName.Size = new System.Drawing.Size(196, 20);
            this.txtSeminarName.TabIndex = 1;
            // 
            // cmbSeminarLevel
            // 
            this.cmbSeminarLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeminarLevel.FormattingEnabled = true;
            this.cmbSeminarLevel.Location = new System.Drawing.Point(133, 83);
            this.cmbSeminarLevel.Name = "cmbSeminarLevel";
            this.cmbSeminarLevel.Size = new System.Drawing.Size(158, 21);
            this.cmbSeminarLevel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seminar Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee No:";
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.BackColor = System.Drawing.Color.White;
            this.txtEmployeeNo.Location = new System.Drawing.Point(133, 31);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(122, 20);
            this.txtEmployeeNo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(12, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 53);
            this.panel3.TabIndex = 53;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(300, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(221, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEditSeminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 332);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditSeminarForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddEditSeminarForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label lblFileName;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Button btnAttachResume;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtSeminarName;
        internal System.Windows.Forms.ComboBox cmbSeminarLevel;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtEmployeeNo;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
    }
}
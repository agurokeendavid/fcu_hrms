namespace HRMS.App.Leave
{
    partial class ListOfEmployeeLeaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfEmployeeLeaveForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.dtgRecords = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label9 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRemainingLeaveCredits = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).BeginInit();
            this.panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnApplyLeave);
            this.panel3.Location = new System.Drawing.Point(12, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 53);
            this.panel3.TabIndex = 52;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Location = new System.Drawing.Point(668, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 43);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(95, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 43);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnApplyLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApplyLeave.BackgroundImage")));
            this.btnApplyLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApplyLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplyLeave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApplyLeave.Location = new System.Drawing.Point(3, 4);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(86, 43);
            this.btnApplyLeave.TabIndex = 47;
            this.btnApplyLeave.Text = "&Apply Leave";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            this.btnApplyLeave.Click += new System.EventHandler(this.btnApplyLeave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 20);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(127, 13);
            this.label36.TabIndex = 37;
            this.label36.Text = "Search by Employee  No:";
            // 
            // dtgRecords
            // 
            this.dtgRecords.AllowUserToAddRows = false;
            this.dtgRecords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            this.dtgRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRecords.BackgroundColor = System.Drawing.Color.White;
            this.dtgRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRecords.ColumnHeadersHeight = 30;
            this.dtgRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeId,
            this.EmployeeNo,
            this.LeaveTypeId,
            this.LeaveType,
            this.LeaveFrom,
            this.LeaveTo,
            this.Reason});
            this.dtgRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgRecords.EnableHeadersVisualStyles = false;
            this.dtgRecords.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dtgRecords.Location = new System.Drawing.Point(6, 60);
            this.dtgRecords.MultiSelect = false;
            this.dtgRecords.Name = "dtgRecords";
            this.dtgRecords.ReadOnly = true;
            this.dtgRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRecords.RowHeadersVisible = false;
            this.dtgRecords.RowHeadersWidth = 25;
            this.dtgRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRecords.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgRecords.RowTemplate.Height = 18;
            this.dtgRecords.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecords.Size = new System.Drawing.Size(735, 261);
            this.dtgRecords.TabIndex = 39;
            this.dtgRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRecords_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblRemainingLeaveCredits);
            this.panel2.Controls.Add(this.dtgRecords);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 365);
            this.panel2.TabIndex = 51;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Teal;
            this.Label9.Location = new System.Drawing.Point(286, 6);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(242, 29);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "EMPLOYEES LEAVE";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(12, 9);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(746, 45);
            this.Panel1.TabIndex = 50;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::HRMS.App.Properties.Resources.filamer_logo;
            this.PictureBox1.Location = new System.Drawing.Point(217, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(63, 37);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 47;
            this.PictureBox1.TabStop = false;
            // 
            // lblRemainingLeaveCredits
            // 
            this.lblRemainingLeaveCredits.AutoSize = true;
            this.lblRemainingLeaveCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingLeaveCredits.Location = new System.Drawing.Point(3, 324);
            this.lblRemainingLeaveCredits.Name = "lblRemainingLeaveCredits";
            this.lblRemainingLeaveCredits.Size = new System.Drawing.Size(249, 24);
            this.lblRemainingLeaveCredits.TabIndex = 40;
            this.lblRemainingLeaveCredits.Text = "Remaining Leave Credits:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Employee ID";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // EmployeeNo
            // 
            this.EmployeeNo.DataPropertyName = "EmployeeNo";
            this.EmployeeNo.HeaderText = "Employee No";
            this.EmployeeNo.Name = "EmployeeNo";
            this.EmployeeNo.ReadOnly = true;
            // 
            // LeaveTypeId
            // 
            this.LeaveTypeId.DataPropertyName = "LeaveTypeId";
            this.LeaveTypeId.HeaderText = "Leave Type ID";
            this.LeaveTypeId.Name = "LeaveTypeId";
            this.LeaveTypeId.ReadOnly = true;
            this.LeaveTypeId.Visible = false;
            // 
            // LeaveType
            // 
            this.LeaveType.DataPropertyName = "LeaveType";
            this.LeaveType.HeaderText = "Type";
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.ReadOnly = true;
            // 
            // LeaveFrom
            // 
            this.LeaveFrom.DataPropertyName = "LeaveFrom";
            this.LeaveFrom.HeaderText = "From";
            this.LeaveFrom.Name = "LeaveFrom";
            this.LeaveFrom.ReadOnly = true;
            // 
            // LeaveTo
            // 
            this.LeaveTo.DataPropertyName = "LeaveTo";
            this.LeaveTo.HeaderText = "To";
            this.LeaveTo.Name = "LeaveTo";
            this.LeaveTo.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // ListOfEmployeeLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfEmployeeLeaveForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfEmployeeLeave";
            this.Load += new System.EventHandler(this.ListOfEmployeeLeaveForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecords)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label label36;
        internal System.Windows.Forms.DataGridView dtgRecords;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRemainingLeaveCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}
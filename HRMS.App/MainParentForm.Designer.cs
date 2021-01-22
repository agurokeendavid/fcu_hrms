namespace HRMS.App
{
    partial class MainParentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainParentForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOfficesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seminarsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSeminarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssCurrentDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.manageLeaveTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.employeesToolStripMenuItem1,
            this.seminarsToolStripMenuItem1,
            this.leaveToolStripMenuItem1});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1920, 40);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem1
            // 
            this.employeesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeesToolStripMenuItem,
            this.manageEmployeeTypeToolStripMenuItem,
            this.manageOfficesToolStripMenuItem,
            this.managePositionsToolStripMenuItem});
            this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
            this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(142, 36);
            this.employeesToolStripMenuItem1.Text = "Employees";
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employees";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // manageEmployeeTypeToolStripMenuItem
            // 
            this.manageEmployeeTypeToolStripMenuItem.Name = "manageEmployeeTypeToolStripMenuItem";
            this.manageEmployeeTypeToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.manageEmployeeTypeToolStripMenuItem.Text = "Manage Employee Type";
            this.manageEmployeeTypeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeTypeToolStripMenuItem_Click);
            // 
            // manageOfficesToolStripMenuItem
            // 
            this.manageOfficesToolStripMenuItem.Name = "manageOfficesToolStripMenuItem";
            this.manageOfficesToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.manageOfficesToolStripMenuItem.Text = "Manage Offices";
            this.manageOfficesToolStripMenuItem.Click += new System.EventHandler(this.manageOfficesToolStripMenuItem_Click);
            // 
            // managePositionsToolStripMenuItem
            // 
            this.managePositionsToolStripMenuItem.Name = "managePositionsToolStripMenuItem";
            this.managePositionsToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.managePositionsToolStripMenuItem.Text = "Manage Positions";
            this.managePositionsToolStripMenuItem.Click += new System.EventHandler(this.managePositionsToolStripMenuItem_Click);
            // 
            // seminarsToolStripMenuItem1
            // 
            this.seminarsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageSeminarsToolStripMenuItem});
            this.seminarsToolStripMenuItem1.Name = "seminarsToolStripMenuItem1";
            this.seminarsToolStripMenuItem1.Size = new System.Drawing.Size(124, 36);
            this.seminarsToolStripMenuItem1.Text = "Seminars";
            // 
            // manageSeminarsToolStripMenuItem
            // 
            this.manageSeminarsToolStripMenuItem.Name = "manageSeminarsToolStripMenuItem";
            this.manageSeminarsToolStripMenuItem.Size = new System.Drawing.Size(281, 36);
            this.manageSeminarsToolStripMenuItem.Text = "Manage Seminars";
            this.manageSeminarsToolStripMenuItem.Click += new System.EventHandler(this.manageSeminarsToolStripMenuItem_Click);
            // 
            // leaveToolStripMenuItem1
            // 
            this.leaveToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeesLeaveToolStripMenuItem,
            this.manageLeaveTypeToolStripMenuItem});
            this.leaveToolStripMenuItem1.Name = "leaveToolStripMenuItem1";
            this.leaveToolStripMenuItem1.Size = new System.Drawing.Size(210, 36);
            this.leaveToolStripMenuItem1.Text = "Employees Leave";
            // 
            // manageEmployeesLeaveToolStripMenuItem
            // 
            this.manageEmployeesLeaveToolStripMenuItem.Name = "manageEmployeesLeaveToolStripMenuItem";
            this.manageEmployeesLeaveToolStripMenuItem.Size = new System.Drawing.Size(367, 36);
            this.manageEmployeesLeaveToolStripMenuItem.Text = "Manage Employees Leave";
            this.manageEmployeesLeaveToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesLeaveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HRMS.App.Properties.Resources.filamer_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 746);
            this.panel1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCurrentDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 35);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssCurrentDateTime
            // 
            this.tssCurrentDateTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssCurrentDateTime.Name = "tssCurrentDateTime";
            this.tssCurrentDateTime.Size = new System.Drawing.Size(87, 30);
            this.tssCurrentDateTime.Text = "tssTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // manageLeaveTypeToolStripMenuItem
            // 
            this.manageLeaveTypeToolStripMenuItem.Name = "manageLeaveTypeToolStripMenuItem";
            this.manageLeaveTypeToolStripMenuItem.Size = new System.Drawing.Size(367, 36);
            this.manageLeaveTypeToolStripMenuItem.Text = "Manage Leave Type";
            this.manageLeaveTypeToolStripMenuItem.Click += new System.EventHandler(this.manageLeaveTypeToolStripMenuItem_Click);
            // 
            // MainParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 786);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "MainParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filamer Christian University - Human Resource Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainParentForm_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seminarsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOfficesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSeminarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesLeaveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssCurrentDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem manageLeaveTypeToolStripMenuItem;
    }
}




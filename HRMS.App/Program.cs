using System;
using System.Windows.Forms;
using HRMS.App.Employees;
using HRMS.App.EmployeeType;
using HRMS.App.Leave;
using HRMS.App.LeaveType;
using HRMS.App.Offices;
using HRMS.App.Seminars;

namespace HRMS.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainParentForm());
        }
    }
}

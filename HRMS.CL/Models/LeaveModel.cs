using System;

namespace HRMS.CL.Models
{
    public class LeaveModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime LeaveFrom { get; set; }
        public DateTime LeaveTo { get; set; }
        public string Reason { get; set; }
        public double LeaveCredits { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeModel Employee { get; set; }
        public LeaveTypeModel LeaveType { get; set; }
    }
}

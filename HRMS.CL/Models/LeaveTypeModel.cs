using System;

namespace HRMS.CL.Models
{
    public class LeaveTypeModel
    {
        public int Id { get; set; }
        public string LeaveType { get; set; }
        public double LeaveCredits { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

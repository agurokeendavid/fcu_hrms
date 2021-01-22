using System;

namespace HRMS.CL.Models
{
    public class SeminarModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string SeminarName { get; set; }
        public int SeminarLevelId { get; set; }
        public string CertificatePath { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeModel Employee { get; set; }
        public SeminarLevelModel SeminarLevel { get; set; }
    }
}

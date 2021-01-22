using System;

namespace HRMS.CL.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PlaceOfBirth { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string CivilStatus { get; set; }
        public int EmployeeTypeId { get; set; }
        public int OfficeId { get; set; }
        public int PositionId { get; set; }
        public int WorkStatusId { get; set; }
        public string HighestDegree { get; set; }
        public string AcquiredDegree { get; set; }
        public string WorkExperience { get; set; }
        public string ResumePath { get; set; }
        public int LeaveCredits { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeTypeModel EmployeeType { get; set; }
        public OfficeModel Office { get; set; }
        public PositionModel Position { get; set; }
        public WorkStatusModel WorkStatus { get; set; }
    }
}

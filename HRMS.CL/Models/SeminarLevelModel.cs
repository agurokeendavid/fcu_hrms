using System;

namespace HRMS.CL.Models
{
    public class SeminarLevelModel
    {
        public int Id { get; set; }
        public string SeminarLevelName { get; set; }
        public int Points { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

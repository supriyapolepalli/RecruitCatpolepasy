namespace RecruitCatpolepasy.Models
{
    public class Candidate
    {
        public int Id { get; set; }  // Primary Key
        public string FirstName { get; set; } // Candidate's First Name
        public string LastName { get; set; } // Candidate's Last Name
        public decimal TargetSalary { get; set; } // Candidate's Target Salary
        public DateTime? StartDate { get; set; } // Optional Start Date
        public int JobTitleId { get; set; }  // Foreign Key to JobTitle
        public JobTitle JobTitle { get; set; } // Navigation property to JobTitle
        public int CompanyId { get; set; }  // Foreign Key to Company
        public Company Company { get; set; } // Navigation property to Company
        public int IndustryId { get; set; }  // Foreign Key to Industry
        public Industry Industry { get; set; } // Navigation property to Industry
    }
}
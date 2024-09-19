namespace RecruitCatpolepasy.Models
{
    public class JobTitle
    {
        public int Id { get; set; } // Primary Key
        public string Title { get; set; } // Job Title Name
        public decimal MinimumSalary { get; set; } // Minimum Salary
        public decimal MaximumSalary { get; set; } // Maximum Salary
         public bool IsRemote { get; set; }
    }
}
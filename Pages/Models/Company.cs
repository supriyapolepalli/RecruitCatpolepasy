namespace RecruitCatpolepasy.Models
{
    public class Company
    { public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public int FoundedYear { get; set; } // Year the company was founded
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatpolepasy.Models
{
    public class Candidate
    {
        public int Id { get; set; } 
         [Required]
    [StringLength(50)]
        [DisplayName ("First Name ")]
 
        public string FirstName { get; set; }
         [Required]
    [StringLength(50)]
[DisplayName ("Last Name ")]
        public string LastName { get; set; } 
         [Required]
    [StringLength(50)]
        [DisplayName ("Target Salary ")]
        public decimal TargetSalary { get; set; } 
 [Required]
    [StringLength(10)]
        [DisplayName ("Start Date ")]
        public DateTime? StartDate { get; set; } 
         [Required]
    [StringLength(50)]
        [DisplayName ("Job Title ID ")]
        
        public int JobTitleId { get; set; } 
         [Required]
    [StringLength(50)]
        [DisplayName ("Job Title ")]
        public JobTitle JobTitle { get; set; } 
         [Required]
    [StringLength(50)]
        [DisplayName ("Company ID ")]
   
        public int CompanyId { get; set; }  
         [Required]
    [StringLength(50)]
        [DisplayName ("Company ")]
        public Company Company { get; set; } 
         [Required]
    [StringLength(50)]
        [DisplayName ("Industry ID ")]
        public int IndustryId { get; set; }  // Foreign Key to Industry
         [Required]
    [StringLength(50)]
        [DisplayName ("Industry ")]
        public Industry Industry { get; set; } // Navigation property to Industry
        [EmailAddress]
public string Email { get; set; }

[Phone]
public string PhoneNumber { get; set; }

[Url]
public string Website { get; set; }
public int Age { get; set; }
public DateTime BirthDate { get; set; }
    }
}
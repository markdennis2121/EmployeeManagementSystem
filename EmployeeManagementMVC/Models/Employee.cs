using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(0, 10000000)]
        public decimal Salary { get; set; }

    }
}
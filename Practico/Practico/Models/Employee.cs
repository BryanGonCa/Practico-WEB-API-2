using System.ComponentModel.DataAnnotations;

namespace Practico.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Birthday { get; set; }
        public string Recommendation { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ServiceBusAutomation.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        public string Boarding { get; set; }
    }
}

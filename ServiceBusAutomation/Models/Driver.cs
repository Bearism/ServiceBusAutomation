using System.ComponentModel.DataAnnotations;

namespace ServiceBusAutomation.Models
{
    public class Driver
    {
        [Key]
        [Required] 
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}

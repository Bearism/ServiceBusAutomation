using System.ComponentModel.DataAnnotations;

namespace ServiceBusAutomation.Models
{
    public class Bus
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required] 
        public int DriverId { get; set; }

        [Required]
        public string Plate { get; set; }

        [Required]
        public string Route { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Shipper : Base
    {
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Name { get; set; }
        [Required]
        public string? OfficialName { get; set; }

        public virtual List<Order>? Order { get; set; }//m-1
    }
}
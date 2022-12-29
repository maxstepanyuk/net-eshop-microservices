using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Status : Base
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual List<Order>? Order { get; set; }//m-1
    }
}
using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Base
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
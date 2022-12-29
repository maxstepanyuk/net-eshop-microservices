using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class Base
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
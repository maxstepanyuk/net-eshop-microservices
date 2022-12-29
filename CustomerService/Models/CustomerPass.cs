using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class CustomerPass : Base
    {
        [Required]
        public string? Password { get; set; }

        public string? Verify { get; set; }

        public virtual Customer? Customer { get; set; }//1-1
    }
}
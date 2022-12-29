using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class CustomerAddress : Base
    {
        public bool IsPrimary { get; set; } = false;

        [Required]
        public int AddressId { get; set; }
        public virtual Address? Address { get; set; } //1-1

        [Required]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } //m-1
    }
}
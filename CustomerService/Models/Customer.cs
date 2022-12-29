using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class Customer : Base
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime RegDate { get; set; } = DateTime.Now;
        public string? ProfilePhotoLink { get; set; }

        [Required]
        public int CustomerPassId { get; set; }
        public virtual CustomerPass? CustomerPass { get; set; }//1-1

        public virtual List<CustomerAddress>? CustomerAddress { get; set; }//1-m
    }
}
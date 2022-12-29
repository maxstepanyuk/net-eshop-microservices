using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class Address : Base
    {
        [Required]
        public string? Street { get; set; }

        [Required]
        public string? Apartment { get; set; }

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? Region { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? PostalCode { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? WebSite { get; set; }

        public int? Fax { get; set; }

        public virtual CustomerAddress? CustomerAddress { get; set; } //1-1
    }
}
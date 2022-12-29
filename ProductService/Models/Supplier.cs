using System.ComponentModel.DataAnnotations;

namespace ProductService.Models
{
    public class Supplier : Base
    {
        public int AddressId { get; set; }//enother db

        [Phone]
        public string Phone { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string OfficialName { get; set; } = null!;
    }
}

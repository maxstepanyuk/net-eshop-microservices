using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Order : Base
    {
        [Required]
        public int CustomerId { get; set; }
        //enother db

        [Required]
        public int ShipperId { get; set; }
        public virtual Shipper? Shipper { get; set; }//1-m

        [Required]
        public int AddressId { get; set; }
        //enother db

        [Required]
        public int StatusId { get; set; }
        public virtual List<Status>? Status { get; set; }//1-m

        [Required]
        public double FreightCost { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime RequiredDate { get; set; }

        [Required]
        public DateTime ShipedDate { get; set; }
    }
}
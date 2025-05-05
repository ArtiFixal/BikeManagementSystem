using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class RentedBike: BaseEntity<RentedBikeKey>
    {
        public DateTime ReturnDate { get; set; }

        [StringLength(255)]
        public string ReturnStatusDescription { get; set; }

        public virtual Bike Bike { get; set; }
        public virtual Rental Rental { get; set; }

        public RentedBike(RentedBikeKey id,DateTime returnDate, string returnStatusDescription): base(id)
        {
            ReturnDate = returnDate;
            ReturnStatusDescription = returnStatusDescription;
        }
    }
}

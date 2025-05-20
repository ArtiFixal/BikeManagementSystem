using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class RentedBike: BaseEntity<RentedBikeKey>
    {
        public long BikeId { get => Id.BikeId;  set { Id.BikeId = value; } }
        public long RentalId { get => Id.RentalId; set { Id.RentalId = value; } }
        public DateTime? ReturnDate { get; set; }

        [StringLength(255)]
        public string? ReturnStatusDescription { get; set; }

        public virtual Bike Bike { get; set; }
        public virtual Rental Rental { get; set; }

        public RentedBike(long bikeId, long rentalId, DateTime? returnDate, string? returnStatusDescription) : this(new RentedBikeKey(rentalId, bikeId),returnDate,returnStatusDescription) { }

        public RentedBike(RentedBikeKey id,DateTime? returnDate, string? returnStatusDescription): base(id)
        {
            ReturnDate = returnDate;
            ReturnStatusDescription = returnStatusDescription;
        }

        public RentedBike(Rental rental, Bike bike): base(new RentedBikeKey(0,bike.Id))
        {
            Rental = rental;
            Bike = bike;
        }
    }
}

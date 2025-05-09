using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    /// <summary>
    /// Represents DB key for RentedBike's.
    /// </summary>
    /// <see cref="RentedBike"/>
    public class RentedBikeKey
    {
        public long RentalId { get; set; }
        public long BikeId { get; set; }

        public RentedBikeKey(long rentalId, long bikeId)
        {
            RentalId = rentalId;
            BikeId = bikeId;
        }
    }
}

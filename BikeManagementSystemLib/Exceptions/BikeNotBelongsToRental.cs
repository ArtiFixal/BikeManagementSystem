namespace BikeManagementSystemLib.Exceptions
{
    public class BikeNotBelongsToRental: Exception
    {
        public BikeNotBelongsToRental(long bikeID, long rentalID) : base($"Bike with ID: {bikeID} doesn't belong to the rental of ID: {rentalID}") { }
    }
}

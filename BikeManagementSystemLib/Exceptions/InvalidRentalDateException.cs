namespace BikeManagementSystemLib.Exceptions
{
    public class InvalidRentalDateException: Exception
    {
        public InvalidRentalDateException(string message) : base(message) { }
    }
}

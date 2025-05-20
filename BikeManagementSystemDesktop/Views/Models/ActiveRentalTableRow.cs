namespace BikeManagementSystemDesktop.Views.Models
{
    /// <summary>
    /// Represents single DataGridView row for <see cref="BikeManagementSystemLib.Models.Rental">Rental</see> 
    /// where not all bikes were returned.
    /// </summary>
    public class ActiveRentalTableRow
    {
        public long Id { get; set; }
        public string Client { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RentedFrom { get; set; }
        public DateTime RentedTo { get; set; }

        public ActiveRentalTableRow(long id, string client, string phoneNumber, DateTime rentedFrom, DateTime rentedTo)
        {
            Id = id;
            Client = client;
            PhoneNumber = phoneNumber;
            RentedFrom = rentedFrom;
            RentedTo = rentedTo;
        }
    }
}

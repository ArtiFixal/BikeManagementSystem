namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class RentalViewModel: BaseViewModel<long?>
    {
        public long ClientID { get; set; }
        public DateTime RentedFrom { get; set; }
        public DateTime RentedTo { get; set; }
        public List<long> BikesId { get; set; }
    }
}

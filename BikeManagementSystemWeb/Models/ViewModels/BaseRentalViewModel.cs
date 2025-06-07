namespace BikeManagementSystemWeb.Models.ViewModels
{
    public abstract class BaseRentalViewModel: BaseViewModel<long?>
    {
        public ClientViewModel Client { get; set; }
        public DateTime RentedFrom { get; set; }
        public DateTime RentedTo { get; set; }
    }
}

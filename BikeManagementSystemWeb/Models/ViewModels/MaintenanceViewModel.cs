namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class MaintenanceViewModel: BaseViewModel<long?>
    {
        public long BikeId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Description { get; set; } 
    }
}

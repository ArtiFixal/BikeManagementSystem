namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class BikeSimpleViewModel: BaseViewModel<long?>
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }
        public long ImageId { get; set; }
        public DateTime? LastMaintenance { get; set; }
    }
}

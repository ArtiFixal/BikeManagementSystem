using BikeManagementSystemLib.Models;

namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class RentedBikeDetailedViewModel: RentedBikeViewModel
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }
        public long ImageId { get; set; }

        public RentedBikeDetailedViewModel() {}
    }
}

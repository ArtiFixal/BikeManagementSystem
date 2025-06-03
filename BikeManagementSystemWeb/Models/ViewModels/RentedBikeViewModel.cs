using BikeManagementSystemLib.Models;

namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class RentedBikeViewModel: BaseViewModel<RentedBikeKey>
    {
        public string? ReturnStatusDescription { get; set; }
        public DateTime? ReturnDate { get; set; }

        public RentedBikeViewModel(){}
    }
}

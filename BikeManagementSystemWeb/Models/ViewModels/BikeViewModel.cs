using BikeManagementSystemLib.Models;

namespace BikeManagementSystemWeb.Models.ViewModels
{
    public class BikeViewModel: BaseViewModel<long?>
    {
        public string Model { get; set; }
        public long VendorId { get; set; }
        public int TypeId { get; set; }

        /// <summary>
        /// Current bike image.
        /// </summary>
        public Image? Image { get; set; }

        /// <summary>
        /// New bike Image.
        /// </summary>
        public IFormFile? ImageFile { get; set; }
        public long? LastMaintenanceId { get; set; }

        public BikeViewModel(){}
    }
}

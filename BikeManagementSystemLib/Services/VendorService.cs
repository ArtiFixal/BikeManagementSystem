using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    /// <summary>
    /// Service related to <see cref="BikeManagementSystemLib.Models.Bike">>Bike</see> vendors.
    /// </summary>
    public class VendorService : CrudService<long, Vendor>
    {
        public VendorService(BikeManagementDbContext context) : base(context,context.Vendors){}
    }
}

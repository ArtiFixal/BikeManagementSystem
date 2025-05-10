using BikeManagementSystemDesktop.Views.Models;
using BikeManagementSystemLib;
using BikeManagementSystemLib.Services;

namespace BikeManagementSystemDesktop.Services
{
    /// <summary>
    /// BikeService extended with View models.
    /// </summary>
    public class BikeServiceExtended : BikeService
    {
        public BikeServiceExtended(BikeManagementDbContext context) : base(context){}

        public List<BikeTableRow> GetBikeTableRowPage(int pageNumber, int pageSize)
        {
            return PrepareEntiytPage(pageNumber, pageSize)
                .Select(bike => new BikeTableRow(bike.Id, bike.Model,
                    bike.Image.Path, bike.Vendor.Name, bike.Type.Name,
                    bike.IsAvailable, bike.LastMaintenance.MaintenanceDate)
                ).ToList();
        }
    }
}

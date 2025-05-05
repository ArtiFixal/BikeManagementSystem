using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    internal class MaintenanceService : CrudService<long, Maintenance>
    {
        public MaintenanceService(BikeManagementDbContext context) : base(context, context.Maintenances) {}
    }
}

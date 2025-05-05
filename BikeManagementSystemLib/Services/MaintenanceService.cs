using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    public class MaintenanceService : CrudService<long, Maintenance>
    {
        public MaintenanceService(BikeManagementDbContext context) : base(context, context.Maintenances) {}
    }
}

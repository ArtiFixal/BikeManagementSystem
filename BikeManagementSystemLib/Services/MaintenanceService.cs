using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    public class MaintenanceService : CrudService<long, Maintenance>
    {
        public MaintenanceService(BikeManagementDbContext context) : base(context, context.Maintenances) {}

        /// <summary>
        /// Sends given bike to maintenace.
        /// </summary>
        /// 
        /// <param name="bikeId">Which bike to send</param>
        /// <exception cref="EntityNotFoundException">If bike was not found</exception>
        public Maintenance MaintenanceBike(long bikeId, DateTime maintenanceDate, string maintenanceDescription)
        {
            Maintenance maintenance = new Maintenance(bikeId, maintenanceDate, maintenanceDescription);
            Bike bike = context.Bikes.First(bike => bike.Id == bikeId) ??
                throw new EntityNotFoundException("Bike", bikeId);
            bike.LastMaintenance = maintenance;
            bike.Durability = 100;
            context.SaveChanges();
            return maintenance;
        }
    }
}

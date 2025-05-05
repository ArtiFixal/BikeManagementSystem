using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    /// <summary>
    /// Service related to Bikes.
    /// </summary>
    public class BikeService: CrudService<long,Bike>
    {
        public BikeService(BikeManagementDbContext context): base(context,context.Bikes){}

        /// <summary>
        /// Sends given bike to maintenace.
        /// </summary>
        /// 
        /// <param name="bikeId">Which bike to send</param>
        /// <exception cref="EntityNotFoundException">If bike was not found</exception>
        public Maintenance MaintenanceBike(int bikeId,string maintenanceDescription)
        {
            Maintenance maintenance=new Maintenance(bikeId,DateTime.Now,maintenanceDescription);
            GetEntity(bikeId).LastMaintenance = maintenance;
            context.SaveChanges();
            return maintenance;
        }

        public List<Bike> GetBikesReqiringMaintenance()
        {
            return entitySet.Where(bike => bike.Durability < 40)
                .ToList();
        }
    }
}

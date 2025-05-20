using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

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

        /// <summary>
        /// Searches for available bikes filtered by given parameters.
        /// </summary>
        /// 
        /// <param name="modelName">How its named</param>
        /// <param name="vendorId">Who manufactured it</param>
        /// <param name="bikeTypeId">What type is is</param>
        /// 
        /// <returns>Filtered available bikes</returns>
        public List<Bike> GetAvailableBikes(string? modelName,long? vendorId,int? bikeTypeId)
        {
            IQueryable<Bike> query = entitySet.Where(bike => bike.IsAvailable);
            if (!string.IsNullOrWhiteSpace(modelName))
            {
                query=query.Where(bike=>bike.Model.Contains(modelName));
            }
            if (vendorId != null)
            {
                query=query.Where(bike => bike.Vendor.Id == vendorId);
            }
            if(bikeTypeId != null)
            {
                query=query.Where(bike=>bike.TypeId==bikeTypeId);
            }
            return query.ToList();
        }

        public List<Bike> GetBikesReqiringMaintenance()
        {
            return entitySet.Where(bike => bike.Durability < 40)
                .ToList();
        }

        public List<Bike> GetNotReturnedBikes()
        {
            return context.RentedBikes
                .Where(rentedBike => rentedBike.ReturnDate.Equals(null))
                .Include(rentedBike=>rentedBike.Bike)
                .Select(rentedBike=>rentedBike.Bike)
                .ToList();
        }
    }
}

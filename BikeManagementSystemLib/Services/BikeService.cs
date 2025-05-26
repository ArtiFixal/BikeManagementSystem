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
        /// Creates query to search for available bikes with given parameters.
        /// </summary>
        /// 
        /// <param name="modelName">How its named</param>
        /// <param name="vendorId">Who manufactured it</param>
        /// <param name="bikeTypeId">What type is is</param>
        /// 
        /// <returns>Query prepared to fetch data</returns>
        protected IQueryable<Bike> PrepareAvailableBikes(string? modelName, long? vendorId, int? bikeTypeId)
        {
            IQueryable<Bike> query = entitySet.Where(bike => bike.IsAvailable);
            if (!string.IsNullOrWhiteSpace(modelName))
            {
                query = query.Where(bike => bike.Model.Contains(modelName));
            }
            if (vendorId != null)
            {
                query = query.Where(bike => bike.Vendor.Id == vendorId);
            }
            if (bikeTypeId != null)
            {
                query = query.Where(bike => bike.TypeId == bikeTypeId);
            }
            return query;
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
            return PrepareAvailableBikes(modelName,vendorId,bikeTypeId)
                .ToList();
        }

        public Task<List<Bike>> GetAvailableBikesAsync(string? modelName, long? vendorId, int? bikeTypeId)
        {
            return PrepareAvailableBikes(modelName, vendorId, bikeTypeId)
                .ToListAsync();
        }

        protected IQueryable<Bike> PrepareBikesRequiringMaintenancePage(int page)
        {
            var wearedBikes = entitySet.Where(bike => bike.Durability < 40);
            return PrepareEntiytPage(wearedBikes, page, DEFAULT_PAGE_SIZE);
        }

        public List<Bike> GetBikesPageRequiringMaintenance(int page)
        {
            return PrepareBikesRequiringMaintenancePage(page)
                .ToList();
        }

        public Task<List<Bike>> GetBikesPageRequiringMaintenanceAsync(int page)
        {
            return PrepareBikesRequiringMaintenancePage(page)
                .ToListAsync();
        }

        protected IQueryable<Bike> PrepareNotReturnedBikes()
        {
            return context.RentedBikes
                .Where(rentedBike => rentedBike.ReturnDate.Equals(null))
                .Include(rentedBike => rentedBike.Bike)
                .Select(rentedBike => rentedBike.Bike);
        }

        public List<Bike> GetNotReturnedBikes()
        {
            return PrepareNotReturnedBikes()
                .ToList();
        }

        public Task<List<Bike>> GetNotReturnedBikesAsync()
        {
            return PrepareNotReturnedBikes()
                .ToListAsync();
        }
    }
}

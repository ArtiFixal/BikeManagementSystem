using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemLib.Services
{
    public class RentalService : CrudService<long, Rental>
    {
        private readonly BikeWearService bikeWearService;

        public RentalService(BikeManagementDbContext context): base(context, context.Rentals)
        {
            bikeWearService=new BikeWearService(context);
        }

        public RentalService(BikeManagementDbContext context,BikeWearService bikeWearService) : base(context, context.Rentals)
        {
            this.bikeWearService = bikeWearService;
        }

        /// <summary>
        /// Creates query looking for active rentals.
        /// </summary>
        /// 
        /// <returns>Ready to fetch query</returns>
        protected IQueryable<Rental> LookForActiveRentals()
        {
            return entitySet.Where(rental => !rental.AllBikesReturned);
        }

        public List<Rental> GetActiveRentalsPage(int page)
        {
            var activeRentals = LookForActiveRentals();
            return PrepareEntiytPage(activeRentals, page, DEFAULT_PAGE_SIZE)
                .ToList();
        }

        public Task<List<Rental>> GetActiveRentalsPageAsync(int page)
        {
            var activeRentals = LookForActiveRentals();
            return PrepareEntiytPage(activeRentals, page, DEFAULT_PAGE_SIZE)
                .ToListAsync();
        }


        /// <summary>
        /// Validates rental entity.
        /// </summary>
        /// 
        /// <param name="entity">What to validate</param>
        /// 
        /// <exception cref="InvalidRentalDateException">If <see cref="Rental.RentedTo"/> date is before <see cref="Rental.RentedFrom"/></exception>
        protected void ValidateRental(Rental entity)
        {
            if (entity.RentedTo < entity.RentedFrom)
                throw new InvalidRentalDateException("Rented to date can't be before rented from date");
        }

        private void MarkBikesNotAvailable(Rental entity)
        {
            foreach (var rentedBike in entity.RentedBikes)
                rentedBike.Bike.IsAvailable = false;
        }

        public override long AddEntity(Rental entity)
        {
            ValidateRental(entity);
            MarkBikesNotAvailable(entity);
            return base.AddEntity(entity);
        }

        public override async Task<long> AddEntityAsync(Rental entity)
        {
            ValidateRental(entity);
            MarkBikesNotAvailable(entity);
            return await base.AddEntityAsync(entity)
                .ConfigureAwait(false);
        }

        protected int CalculateBikeWear(Rental rental,decimal wearMultiplier)
        {
            int daysPassed=(rental.RentedTo-rental.RentedFrom).Days;
            return (int)Math.Round(10 * wearMultiplier * daysPassed);
        }

        protected RentedBike PrepareBikeReturn(long rentalID, long bikeID, string? returnStatusDescription)
        {
            Rental rental = entitySet.Where(rental => rental.Id == rentalID).First() ??
                throw new EntityNotFoundException("Rental", rentalID);
            RentedBike bikeToReturn = rental.RentedBikes.First(rentedBike => rentedBike.BikeId == bikeID)
                ?? throw new BikeNotBelongsToRental(bikeID, rentalID);
            bikeToReturn.ReturnDate = DateTime.Now;
            bikeToReturn.ReturnStatusDescription = returnStatusDescription;
            // Make bike available again
            bikeToReturn.Bike.IsAvailable = true;
            // Wear bike
            BikeWearKey wearToLookFor = new BikeWearKey(bikeToReturn.Bike.Type.Id, rental.TerrainID);
            BikeWear bikeWear = bikeWearService.GetEntity(wearToLookFor);
            bikeToReturn.Bike.Durability -= CalculateBikeWear(rental, bikeWear.WearRatio);
            if (bikeToReturn.Bike.Durability < 0)
                bikeToReturn.Bike.Durability = 0;
            // Make rental unactive
            int leftUnreturned = rental.RentedBikes.Count(bike => bike.ReturnDate == null);
            if (leftUnreturned == 0)
                rental.AllBikesReturned = true;
            return bikeToReturn;
        }

        public RentedBike ReturnBike(long rentalID,long bikeID,string? returnStatusDescription)
        {
            var bikeToReturn = PrepareBikeReturn(rentalID, bikeID, returnStatusDescription);
            context.SaveChanges();
            return bikeToReturn;
        }

        public async Task<RentedBike> ReturnBikeAsync(long rentalID, long bikeID, string? returnStatusDescription)
        {
            var bikeToReturn = PrepareBikeReturn(rentalID, bikeID, returnStatusDescription);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return bikeToReturn;
        }

        /// <summary>
        /// Creates query to fetch rented bikes in given rental.
        /// </summary>
        /// 
        /// <param name="rentalID">Where to look for bikes</param>
        /// 
        /// <returns>Ready to fetch query</returns>
        protected IQueryable<RentedBike> PrepareRentedBikes(long rentalID)
        {
            return context.RentedBikes
                .Where(rentedBike => rentedBike.RentalId == rentalID);
        }

        public List<RentedBike> GetRentedBikes(long rentalID)
        {
            return PrepareRentedBikes(rentalID)
                .ToList();
        }

        public Task<List<RentedBike>> GetRentedBikesAsync(long rentalID)
        {
            return PrepareRentedBikes(rentalID)
                .ToListAsync();
        }

        public int GetActiveRentalsPageCount(int pageSize)
        {
            return LookForActiveRentals()
                .Count()/pageSize;
        }

        public async Task<int> GetActiveRentalsPageCountAsync(int pageSize)
        {
            return await LookForActiveRentals()
                .CountAsync()
                .ConfigureAwait(false) / pageSize;
        }

        public bool RentalHasBike(long rentalID, long bikeID)
        {
            return context.RentedBikes.Any(bike => bike.RentalId == rentalID && bike.BikeId == bikeID);
        }

        public async Task<bool> RentalHasBikeAsync(long rentalID,long bikeID)
        {
            return await context.RentedBikes.AnyAsync(
                bike => bike.RentalId == rentalID && bike.BikeId == bikeID)
                .ConfigureAwait(false);
        }
    }
}

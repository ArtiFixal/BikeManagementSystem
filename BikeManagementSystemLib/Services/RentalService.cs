using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    public class RentalService : CrudService<long, Rental>
    {
        public RentalService(BikeManagementDbContext context): base(context, context.Rentals){}

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

        public override long AddEntity(Rental entity)
        {
            if (entity.RentedTo < entity.RentedFrom)
                throw new InvalidRentalDateException("Rented to date can't be before rented from date");
            foreach (var rentedBike in entity.RentedBikes)
            {
                rentedBike.Bike.IsAvailable = false;
            }
            return base.AddEntity(entity);
        }

        protected int CalculateBikeWear(Rental rental,decimal wearMultiplier)
        {
            int daysPassed=(rental.RentedTo-rental.RentedFrom).Days;
            return (int)Math.Round(10 * wearMultiplier * daysPassed);
        }

        public RentedBike ReturnBike(long rentalID,long bikeID,string? returnStatusDescription)
        {
            var rental=entitySet.Where(rental=>rental.Id==rentalID).First() ??
                throw new EntityNotFoundException("Rental", rentalID);
            var bikeToReturn=rental.RentedBikes.First(rentedBike => rentedBike.BikeId == bikeID)
                ?? throw new BikeNotBelongsToRental(bikeID,rentalID);
            bikeToReturn.ReturnDate = DateTime.Now;
            bikeToReturn.ReturnStatusDescription = returnStatusDescription;
            // Make bike available again
            bikeToReturn.Bike.IsAvailable = true;
            // Wear bike
            bikeToReturn.Bike.Durability -= CalculateBikeWear(rental, 1);
            if (bikeToReturn.Bike.Durability < 0)
                bikeToReturn.Bike.Durability = 0;
            // Make rental unactive
            int leftUnreturned = rental.RentedBikes.Count(bike => bike.ReturnDate == null);
            if(leftUnreturned==0)
                rental.AllBikesReturned = true;
            context.SaveChanges();
            return bikeToReturn;
        }

        public List<RentedBike> GetRentedBikes(long rentalID)
        {
            return context.RentedBikes
                .Where(rentedBike => rentedBike.RentalId == rentalID)
                .ToList();
        }

        public long GetActiveRentalsPageCount(int pageSize)
        {
            return LookForActiveRentals()
                .Count()/pageSize;
        }
    }
}

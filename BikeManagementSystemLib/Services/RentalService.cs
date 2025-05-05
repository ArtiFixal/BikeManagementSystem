using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemLib.Services
{
    public class RentalService : CrudService<long, Rental>
    {
        public RentalService(BikeManagementDbContext context): base(context, context.Rentals)
        {
        }
    }
}

using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    /// <summary>
    /// Service related to <see cref="Bike">Bike</see> types.
    /// </summary>
    public class BikeTypeService : CrudService<int, BikeType>
    {
        public BikeTypeService(BikeManagementDbContext context) : base(context, context.BikeTypes){}
    }
}

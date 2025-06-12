using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemLib.Services
{
    public class BikeWearService : CrudService<BikeWearKey, BikeWear>
    {
        public BikeWearService(BikeManagementDbContext context) : base(context, context.BikeWears) {}

        public override BikeWear GetEntity(BikeWearKey entityID)
        {
            return entitySet.FirstOrDefault(bikeWear=>bikeWear.BikeTypeId==entityID.BikeTypeId 
                && bikeWear.TerrainId==entityID.TerrainId) 
                ?? throw new EntityNotFoundException("BikeWear",entityID);
        }

        public override Task<BikeWear> GetEntityAsync(BikeWearKey entityID)
        {
            return entitySet.FirstOrDefaultAsync(bikeWear => bikeWear.BikeTypeId == entityID.BikeTypeId
                && bikeWear.TerrainId == entityID.TerrainId)
                ?? throw new EntityNotFoundException("BikeWear", entityID);
        }
    }
}

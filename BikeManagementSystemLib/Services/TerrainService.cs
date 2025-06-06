using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    public class TerrainService : CrudService<int, Terrain>
    {
        public TerrainService(BikeManagementDbContext context) : base(context, context.Terrains) {}
    }
}

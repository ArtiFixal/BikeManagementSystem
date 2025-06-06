using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.ViewModels;

namespace BikeManagementSystemWeb.Controllers
{
    public class TerrainsController : CrudController<int, Terrain, TerrainService, int?, TerrainViewModel>
    {
        public TerrainsController(TerrainService service) : base(service) {}

        protected override TerrainViewModel MapEntityToViewModel(Terrain entity)
        {
            return new TerrainViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }

        protected override Terrain MapViewModelToEntity(TerrainViewModel viewModel)
        {
            return new Terrain(viewModel.Id??0,viewModel.Name);
        }
    }
}

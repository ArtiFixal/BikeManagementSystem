using Microsoft.AspNetCore.Mvc.Rendering;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.ViewModels;
using BikeManagementSystemWeb.Services;

namespace BikeManagementSystemWeb.Controllers
{
    public class BikesController : CrudController<long,Bike,BikeService,long?,BikeViewModel>
    {
        private readonly VendorService vendorService;
        private readonly BikeTypeService bikeTypeService;
        private readonly ImageServiceExtended imageService;

        public BikesController(BikeService service,VendorService vendorService,BikeTypeService bikeTypeService,ImageServiceExtended imageService) : base(service)
        {
            this.vendorService = vendorService;
            this.bikeTypeService = bikeTypeService;
            this.imageService = imageService;
        }

        protected override async Task BindViewData(Bike? entity = null)
        {
            ViewData["TypeId"] = new SelectList(await bikeTypeService.GetAllEntitiesAsync(), "Id", "Name");
            ViewData["VendorId"] = new SelectList(await vendorService.GetAllEntitiesAsync(), "Id", "Name");
        }

        protected override BikeViewModel MapEntityToViewModel(Bike entity)
        {
            return new BikeViewModel(){
                Id = entity.Id,
                Model=entity.Model,
                Image=entity.Image,
                VendorId=entity.VendorId,
                TypeId=entity.TypeId,
                LastMaintenanceId=entity.LastMaintenanceId,
            };
        }

        protected override Bike MapViewModelToEntity(BikeViewModel viewModel)
        {
            if(viewModel.ImageFile==null)
            {
                throw new ArgumentException("Bike image is required");
            }
            long imageId=imageService.AddImage(viewModel.ImageFile).Result;
            return new Bike(viewModel.Id??0,viewModel.Model,viewModel.VendorId,viewModel.TypeId,imageId,true,100,null);
        }
    }
}

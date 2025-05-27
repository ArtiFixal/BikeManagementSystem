using Microsoft.AspNetCore.Mvc;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.ViewModels;

namespace BikeManagementSystemWeb.Controllers
{
    public class VendorsController : CrudController<long,Vendor,VendorService,long?,VendorViewModel>
    {
        public VendorsController(VendorService service) : base(service){}

        public override Task<IActionResult> Index(int page = 1)
        {
            return base.Index(page);
        }

        protected override Vendor MapViewModelToEntity(VendorViewModel viewModel)
        {
            return new Vendor(viewModel.Id??0, viewModel.Name);
        }
    }
}

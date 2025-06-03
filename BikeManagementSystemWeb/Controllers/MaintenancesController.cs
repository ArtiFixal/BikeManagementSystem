using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.PageViewModels;
using BikeManagementSystemWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BikeManagementSystemWeb.Controllers
{
    public class MaintenancesController: CrudController<long, Maintenance, MaintenanceService, long?, MaintenanceViewModel>
    {
        private readonly BikeService bikeService;

        public MaintenancesController(MaintenanceService service,BikeService bikeService): base(service)
        {
            this.bikeService = bikeService;
        }

        [HttpGet("/Bikes/{bikeID}/Maintenance")]
        public async Task<IActionResult> MaintenanceBike(long bikeID)
        {
            try
            {
                ViewData["bike"] = await bikeService.GetEntityAsync(bikeID);
                return View();
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost("Maintenance")]
        public async Task<IActionResult> Maintenance(MaintenanceViewModel viewModel)
        {
            await service.MaintenanceBikeAsync(viewModel.BikeId,viewModel.MaintenanceDate,viewModel.Description);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Bikes/{bikeID}/Maintenances")]
        public async Task<IActionResult> BikeMaintenances(long bikeID)
        {
            try
            {
                var bike = await bikeService.GetEntityAsync(bikeID);
                ViewData["bike"] = bike;
                var maintenances = bike.Maintenances.Select(maintenance => new MaintenanceViewModel()
                {
                    Id = maintenance.Id,
                    MaintenanceDate = maintenance.MaintenanceDate,
                    Description = maintenance.Description,
                }).OrderByDescending(maintenance=>maintenance.MaintenanceDate)
                    .ToList();
                return View(maintenances);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        public override async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = BikeService.DEFAULT_PAGE_SIZE;
            int maxPage = await bikeService.GetBikesRequiringMaintenancePageCountAsync(pageSize);
            var bikesToMaintenance=(await bikeService.GetBikesPageRequiringMaintenanceAsync(page))
                .Select(bike=>new BikeToMaintenanceViewModel()
                {
                    Id = bike.Id,
                    Model=bike.Model,
                    ImageId=bike.ImageId,
                    Vendor=bike.Vendor.Name,
                    Type=bike.Type.Name,
                    Durability=bike.Durability,
                    LastMaintenance=bike.LastMaintenance?.MaintenanceDate,
                }).ToList();
            ViewData["page"] = new PagingViewModel()
            {
                CurrentPage = page,
                MaxPage = maxPage,
            };
            return View(bikesToMaintenance);
        }

        public override Task<IActionResult> Edit(long id)
        {
            return NotFoundAsync();
        }

        public override Task<IActionResult> Edit(long id, MaintenanceViewModel viewModel)
        {
            return NotFoundAsync();
        }

        public override Task<IActionResult> Delete(long id)
        {
            return NotFoundAsync();
        }

        public override Task<IActionResult> DeleteConfirmed(long id)
        {
            return NotFoundAsync();
        }

        protected override MaintenanceViewModel MapEntityToViewModel(Maintenance entity)
        {
            return new MaintenanceViewModel()
            {
                Id = entity.Id,
                BikeId = entity.BikeId,
                MaintenanceDate = entity.MaintenanceDate,
                Description = entity.Description,
            };
        }

        protected override Maintenance MapViewModelToEntity(MaintenanceViewModel viewModel)
        {
            return new Maintenance(viewModel.Id ?? 0, viewModel.BikeId, viewModel.MaintenanceDate, viewModel.Description);
        }
    }
}

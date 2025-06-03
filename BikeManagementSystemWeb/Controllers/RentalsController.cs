using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.PageViewModels;
using BikeManagementSystemWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BikeManagementSystemWeb.Controllers
{
    public class RentalsController : CrudController<long, Rental, RentalService, long?, RentalViewModel>
    {
        private readonly BikeService bikeService;
        private readonly VendorService vendorService;
        private readonly BikeTypeService bikeTypeService;
        private readonly ClientService clientService;


        public RentalsController(RentalService service,BikeService bikeService, ClientService clientService, VendorService vendorService, BikeTypeService bikeTypeService) : base(service)
        {
            this.bikeService = bikeService;
            this.clientService = clientService;
            this.vendorService = vendorService;
            this.bikeTypeService = bikeTypeService;
        }

        protected override async Task BindViewData(Rental? entity = null)
        {
            var clients = await clientService.GetAllEntitiesAsync();
            ViewData["Bikes"] = await bikeService.GetAvailableBikesAsync(null,null,null);
            ViewData["Vendors"] = new SelectList(await vendorService.GetAllEntitiesAsync(),"Id","Name");
            ViewData["BikeTypes"] = new SelectList(await bikeTypeService.GetAllEntitiesAsync(), "Id", "Name");
            ViewData["ClientID"] = new SelectList(clients.Select(client=>new {
                Id = client.Id,
                FullName = client.ToString(),
            }),"Id", "FullName");
        }

        public override async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = RentalService.DEFAULT_PAGE_SIZE;
            int maxPage = await service.GetActiveRentalsPageCountAsync(pageSize) + 1;
            ViewData["page"] = new PagingViewModel()
            {
                CurrentPage = page,
                MaxPage = maxPage,
            };
            return View(await service.GetActiveRentalsPageAsync(page));
        }

        [HttpGet("{rentalID?}/Open")]
        public async Task<IActionResult> Open(long? rentalID)
        {
            if (rentalID == null)
                return NotFound();
            try
            {
                Rental rental = await service.GetEntityAsync((long)rentalID);
                var client = MapClientToViewModel(rental.Client);
                var rentedBikes = rental.RentedBikes.Select(bike => new RentedBikeDetailedViewModel()
                {
                    Id = bike.Id,
                    Model=bike.Bike.Model,
                    Vendor=bike.Bike.Vendor.Name,
                    Type=bike.Bike.Type.Name,
                    ImageId=bike.Bike.ImageId,
                    ReturnDate=bike.ReturnDate,
                    ReturnStatusDescription=bike.ReturnStatusDescription,
                }).ToList();
                var viewModel = new ActiveRentalOpenViewModel()
                {
                    Id=rental.Id,
                    RentedFrom = rental.RentedFrom,
                    RentedTo = rental.RentedTo,
                    Client=client,
                    RentedBikes=rentedBikes,
                };
                return View(viewModel);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpGet("{rentalID}/ReturnBike/{bikeID}")]
        public async Task<IActionResult> ReturnBike(long rentalID, long bikeID)
        {
            if(!await service.RentalHasBikeAsync(rentalID, bikeID))
                return NotFound();
            try
            {
                ViewData["key"] = new RentedBikeKey(rentalID,bikeID);
                ViewData["bike"] = await bikeService.GetEntityAsync(bikeID);
                return View();
            }
            catch(EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost("{rentalID}/ReturnBike/{bikeID}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReturnBike([FromRoute] long rentalID, [FromRoute] long bikeID, [FromForm] string? returnStatusDescription)
        {
                await service.ReturnBikeAsync(rentalID, bikeID, returnStatusDescription);
                return RedirectToAction(nameof(Open), new { rentalID });
        }

        protected ClientViewModel MapClientToViewModel(Client client)
        {
            return new ClientViewModel()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                IdentityNumber = client.IdentityNumber,
                PhoneNumber = client.PhoneNumber,
            };
        }

        private Task<IActionResult> NotFoundAsync()
        {
            return Task.FromResult<IActionResult>(NotFound());
        }

        public override Task<IActionResult> Edit(long id)
        {
            return NotFoundAsync();
        }

        public override Task<IActionResult> Edit(long id, RentalViewModel viewModel)
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

        protected override RentalViewModel MapEntityToViewModel(Rental entity)
        {
            // Map RentedBikes to RentedBikeViewModels
            var rentedBikes = entity.RentedBikes.Select(bike => bike.BikeId)
                .ToList();
            // Map Client to ClientViewModel
            var client = MapClientToViewModel(entity.Client);
            return new RentalViewModel()
            {
                Id = entity.Id,
                ClientID=entity.ClientID,
                RentedFrom=entity.RentedFrom,
                RentedTo=entity.RentedTo,
                BikesId=rentedBikes,
            };
        }

        protected override Rental MapViewModelToEntity(RentalViewModel viewModel)
        {
            // Map RentalViewModel to Rental
            Rental rental = new()
            {
                Id = viewModel.Id ?? 0,
                ClientID=viewModel.ClientID,
                RentedFrom = viewModel.RentedFrom,
                RentedTo = viewModel.RentedTo,
                AllBikesReturned = false,
                RentedBikes = [],
            };
            viewModel.BikesId.ForEach(bikeID =>
            {
                Bike bike = bikeService.GetEntity(bikeID);
                RentedBike toRent = new RentedBike(rental,bike);
                rental.RentedBikes.Add(toRent);
            });
            return rental;
        }
    }
}
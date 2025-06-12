using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.PageViewModels;
using BikeManagementSystemWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BikeManagementSystemWeb.Controllers
{
    [Route("[controller]")]
    public class BikeWearsController: Controller
    {
        private readonly BikeWearService bikeWearService;
        private readonly TerrainService terrainService;
        private readonly BikeTypeService bikeTypeService;

        public BikeWearsController(BikeWearService bikeWearService, TerrainService terrainService, BikeTypeService bikeTypeService)
        {
            this.bikeWearService = bikeWearService;
            this.terrainService = terrainService;
            this.bikeTypeService = bikeTypeService;
        }

        [HttpGet("{bikeTypeID}/{page?}")]
        public async Task<IActionResult> Index(int bikeTypeID, int? page=1)
        {
            int pageSize = TerrainService.DEFAULT_PAGE_SIZE;
            var terrains = (await terrainService.GetEntityPageAsync((int)page, pageSize))
                .Select(terrain=>MapTerrainEntityToViewModel(terrain,bikeTypeID));
            int maxPage = await terrainService.GetPageCountAsync(pageSize) + 1;
            ViewData["bikeType"] = await bikeTypeService.GetEntityAsync(bikeTypeID);
            ViewData["page"] = new PagingViewModel()
            {
                CurrentPage = (int)page,
                MaxPage = maxPage,
            };
            return View(terrains);
        }

        [HttpGet("{bikeTypeID}/Terrain/{terrainID}/Edit")]
        public async Task<IActionResult> Edit(int bikeTypeID,int terrainID)
        {
            ViewData["bikeType"] = await bikeTypeService.GetEntityAsync(bikeTypeID);
            try
            {
                BikeWear bikeWear = await bikeWearService.GetEntityAsync(new BikeWearKey(bikeTypeID, terrainID));
                BikeWearViewModel viewModel= new BikeWearViewModel()
                {
                    BikeTypeID = bikeTypeID,
                    TerrainID = terrainID,
                    Terrain = bikeWear.Terrain.Name,
                    WearRatio = bikeWear.WearRatio,
                };
                return View(viewModel);
            }
            catch (EntityNotFoundException)
            {
                Terrain terrain = await terrainService.GetEntityAsync(bikeTypeID);
                return View(MapTerrainEntityToViewModel(terrain,bikeTypeID));
            }
        }

        [HttpPost("{bikeTypeID}/Terrain/{terrainID}/Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int bikeTypeID, int terrainID, [FromForm] string wearRatio)
        {
            if (!decimal.TryParse(wearRatio, out decimal wearRatioValue))
                return BadRequest("Wear ratio is not a floating point number");
            BikeWear toUpdate = new(bikeTypeID, terrainID, wearRatioValue);
            await bikeWearService.EditEntityAsync(toUpdate);
            return RedirectToAction(nameof(Index), new { bikeTypeID });
        }

        protected BikeWearViewModel MapTerrainEntityToViewModel(Terrain terrain,int bikeTypeID)
        {
            return new BikeWearViewModel()
            {
                BikeTypeID = bikeTypeID,
                TerrainID = terrain.Id,
                Terrain = terrain.Name,
                WearRatio = terrain.BikeWears.FirstOrDefault(wear => wear.BikeTypeId == bikeTypeID
                    && wear.TerrainId == terrain.Id)?.WearRatio
            };
        }
    }
}

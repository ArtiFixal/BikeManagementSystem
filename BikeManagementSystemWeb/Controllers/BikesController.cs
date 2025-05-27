using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BikeManagementSystemLib;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.ViewModels;
using System.Threading.Tasks;

namespace BikeManagementSystemWeb.Controllers
{
    public class BikesController //: CrudController<long,Bike,BikeService,long?,BikeViewModel>
    {
        private readonly VendorService vendorService;
        private readonly BikeTypeService bikeTypeService;
        private readonly ImageService imageService;
        public BikesController(BikeService service) { } //: base(service){}

    //    // GET: Bikes
    //    [HttpGet("Bikes/{page?}")]
    //    public async Task<IActionResult> Index(int page=1)
    //    {
    //        return View(await bikeService.GetEntityPageAsync(page,BikeService.DEFAULT_PAGE_SIZE));
    //    }

    //    // GET: Bikes/Details/5
    //    public async Task<IActionResult> Details(long? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var bike = await _context.Bikes
    //            .Include(b => b.Image)
    //            .Include(b => b.LastMaintenance)
    //            .Include(b => b.Type)
    //            .Include(b => b.Vendor)
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (bike == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(bike);
    //    }

    //    // GET: Bikes/Create
    //    public IActionResult Create()
    //    {
    //        ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Path");
    //        ViewData["LastMaintenanceId"] = new SelectList(_context.Maintenances, "Id", "Description");
    //        ViewData["TypeId"] = new SelectList(_context.BikeTypes, "Id", "Name");
    //        ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name");
    //        return View();
    //    }

    //    // POST: Bikes/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Model,VendorId,TypeId,ImageId,IsAvailable,Durability,LastMaintenanceId,Id")] Bike bike)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(bike);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Path", bike.ImageId);
    //        ViewData["LastMaintenanceId"] = new SelectList(_context.Maintenances, "Id", "Description", bike.LastMaintenanceId);
    //        ViewData["TypeId"] = new SelectList(_context.BikeTypes, "Id", "Name", bike.TypeId);
    //        ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", bike.VendorId);
    //        return View(bike);
    //    }

    //    // GET: Bikes/Edit/5
    //    public async Task<IActionResult> Edit(long? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var bike = await _context.Bikes.FindAsync(id);
    //        if (bike == null)
    //        {
    //            return NotFound();
    //        }
    //        ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Path", bike.ImageId);
    //        ViewData["LastMaintenanceId"] = new SelectList(_context.Maintenances, "Id", "Description", bike.LastMaintenanceId);
    //        ViewData["TypeId"] = new SelectList(_context.BikeTypes, "Id", "Name", bike.TypeId);
    //        ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", bike.VendorId);
    //        return View(bike);
    //    }

    //    // POST: Bikes/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(long id, [Bind("Model,VendorId,TypeId,ImageId,IsAvailable,Durability,LastMaintenanceId,Id")] Bike bike)
    //    {
    //        if (id != bike.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(bike);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!BikeExists(bike.Id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Path", bike.ImageId);
    //        ViewData["LastMaintenanceId"] = new SelectList(_context.Maintenances, "Id", "Description", bike.LastMaintenanceId);
    //        ViewData["TypeId"] = new SelectList(_context.BikeTypes, "Id", "Name", bike.TypeId);
    //        ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", bike.VendorId);
    //        return View(bike);
    //    }

    //    // GET: Bikes/Delete/5
    //    public async Task<IActionResult> Delete(long? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var bike = await _context.Bikes
    //            .Include(b => b.Image)
    //            .Include(b => b.LastMaintenance)
    //            .Include(b => b.Type)
    //            .Include(b => b.Vendor)
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (bike == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(bike);
    //    }

    //    // POST: Bikes/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(long id)
    //    {
    //        var bike = await _context.Bikes.FindAsync(id);
    //        if (bike != null)
    //        {
    //            _context.Bikes.Remove(bike);
    //        }

    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool BikeExists(long id)
    //    {
    //        return _context.Bikes.Any(e => e.Id == id);
    //    }

    //    protected override async Task BindViewData(Bike? entity = null)
    //    {
    //        ViewData["TypeId"] = new SelectList(await bikeTypeService.GetAllEntitiesAsync(), "Id", "Name");
    //        ViewData["VendorId"] = new SelectList(await vendorService.GetAllEntitiesAsync(), "Id", "Name");
    //    }

    //    protected override Bike MapViewModelToEntity(BikeViewModel viewModel)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}

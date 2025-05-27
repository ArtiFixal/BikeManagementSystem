using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models;
using BikeManagementSystemWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemWeb.Controllers
{
    [Route("[controller]")]
    public abstract class CrudController<ID,ET,S,VID,VM> : Controller where ET: BaseEntity<ID>
        where S : CrudService<ID,ET>
        where VM: BaseViewModel<VID>
    {

        protected readonly S service;

        public CrudController(S service)
        {
            this.service = service;
        }

        // GET: EntityTable
        [HttpGet("{page?}")]
        public virtual async Task<IActionResult> Index(int page=1)
        {
            int pageSize = CrudService<ID, ET>.DEFAULT_PAGE_SIZE;
            int maxPage=await service.GetPageCountAsync(pageSize)+1;
            Page<ET> pageable=new(page,maxPage, await service.GetEntityPageAsync(page, pageSize));
            return View(pageable);
        }

        // GET: Entit/5/Details
        [HttpGet("{id?}/Details")]
        public virtual async Task<IActionResult> Details(ID? id)
        {
            if (id == null)
                return NotFound();
            try
            {
                var entity=await service.GetEntityAsync(id);
                return View(entity);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Binds required child entities to the <see cref="Controller.ViewData"/>.
        /// </summary>
        protected abstract void BindViewData(ET? entity=null);

        protected abstract ET MapViewModelToEntity(VM viewModel);

        // GET: Entity/Create
        [HttpGet("Create")]
        public virtual IActionResult Create()
        {
            BindViewData();
            return View();
        }

        // POST: Entity/Create
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Create(VM viewModel)
        {
            if (ModelState.IsValid)
            {
                ET entity = MapViewModelToEntity(viewModel);
                await service.AddEntityAsync(entity);
                return RedirectToAction(nameof(Index));
            }
            BindViewData();
            return View(viewModel);
        }

        // GET: Entity/5/Edit
        [HttpGet("{id?}/Edit")]
        public async Task<IActionResult> Edit(ID? id)
        {
            if (id == null)
                return NotFound();
            try
            {
                var toEdit = await service.GetEntityAsync(id);
                BindViewData();
                return View(toEdit);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound();
            }
        }

        // POST: Entity/Edit/5
        [HttpPost("{id?}/Edit")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Edit(ID id, VM viewModel)
        {
            if (!id.Equals(viewModel.Id))
                return NotFound();
            if(ModelState.IsValid)
            {
                try
                {
                    ET entity = MapViewModelToEntity(viewModel);
                    await service.EditEntityAsync(entity);
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!await service.ExistsAsync(id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            BindViewData();
            return View(viewModel);
        }

        // GET: Entity/5/Delete
        [HttpGet("{id?}/Delete")]
        public async Task<IActionResult> Delete(ID? id)
        {
            if (id == null)
                return NotFound();
            try
            {
                var entity= await service.GetEntityAsync(id);
                return View(entity);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound();
            }
        }

        // POST: Entity/5/Delete
        [HttpPost("{id?}/Delete"),ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ID id)
        {
            try
            {
                await service.DeleteEntityAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch(EntityNotFoundException)
            {
                return NotFound();
            }
        }
    }
}

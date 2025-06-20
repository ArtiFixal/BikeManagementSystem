﻿using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.PageViewModels;
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
            ViewData["page"] = new PagingViewModel()
            {
                CurrentPage = page,
                MaxPage= maxPage,
            };
            return View(await service.GetEntityPageAsync(page, pageSize));
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
        protected virtual Task BindViewData(ET? entity = null)
        {
            return Task.CompletedTask;
        }

        protected abstract ET MapViewModelToEntity(VM viewModel);
        protected abstract VM MapEntityToViewModel(ET entity);

        // GET: Entity/Create
        [HttpGet("Create")]
        public virtual async Task<IActionResult> Create()
        {
            await BindViewData();
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
            await BindViewData();
            return View(viewModel);
        }

        // GET: Entity/5/Edit
        [HttpGet("{id?}/Edit")]
        public virtual async Task<IActionResult> Edit(ID? id)
        {
            if (id == null)
                return NotFound();
            try
            {
                var toEdit = await service.GetEntityAsync(id);
                VM toEditViewModel=MapEntityToViewModel(toEdit);
                await BindViewData();
                return View(toEditViewModel);
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
            await BindViewData();
            return View(viewModel);
        }

        // GET: Entity/5/Delete
        [HttpGet("{id?}/Delete")]
        public virtual async Task<IActionResult> Delete(ID? id)
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
        public virtual async Task<IActionResult> DeleteConfirmed(ID id)
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

        protected Task<IActionResult> NotFoundAsync()
        {
            return Task.FromResult<IActionResult>(NotFound());
        }
    }
}

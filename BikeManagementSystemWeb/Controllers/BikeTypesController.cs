﻿using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;
using BikeManagementSystemWeb.Models.ViewModels;

namespace BikeManagementSystemWeb.Controllers
{
    public class BikeTypesController : CrudController<int, BikeType, BikeTypeService, int?, BikeTypeViewModel>
    {
        public BikeTypesController(BikeTypeService service) : base(service){}

        protected override BikeTypeViewModel MapEntityToViewModel(BikeType entity)
        {
            return new BikeTypeViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }

        protected override BikeType MapViewModelToEntity(BikeTypeViewModel viewModel)
        {
            return new BikeType(viewModel.Id??0,viewModel.Name);
        }
    }
}

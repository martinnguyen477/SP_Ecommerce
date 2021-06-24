using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class PublisherSliderViewComponent : ViewComponent
    {
        private readonly MyDbContext myDbContext;
        private readonly IPublishersService _publishersService;
        public PublisherSliderViewComponent (MyDbContext myDbContext, IPublishersService publishersService)
        {
            this.myDbContext = myDbContext;
            this._publishersService = publishersService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var publishers = this._publishersService.GetPublishersWithoutBooks();
            return Task.FromResult<IViewComponentResult>(View(publishers));
        }
    }
}

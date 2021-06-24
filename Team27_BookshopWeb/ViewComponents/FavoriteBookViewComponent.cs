using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class FavoriteBookViewComponent : ViewComponent
    {
        private ICustomerService _customerService;

        public FavoriteBookViewComponent(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        public Task<IViewComponentResult> InvokeAsync(string bookId)
        {
            bool isFavorited = false;
            if (User.Identity.IsAuthenticated)
            {
                string customerId = UserClaimsPrincipal.FindFirst("Id").Value;
                isFavorited = _customerService.IsFavorited(customerId, bookId);
            }
            ViewBag.BookId = bookId;
            return Task.FromResult<IViewComponentResult>(View("FavoriteBook", isFavorited));
        }
    }
}

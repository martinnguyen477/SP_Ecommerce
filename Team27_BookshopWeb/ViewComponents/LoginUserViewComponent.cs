using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class LoginUserViewComponent : ViewComponent
    {
        private ICustomerService _customerService;

        public LoginUserViewComponent(ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                string id = UserClaimsPrincipal.FindFirst("Id").Value;
                Customer customer = _customerService.GetCustomer(id);
                ViewBag.Name = customer.DisplayName;
            }

            return Task.FromResult<IViewComponentResult>(View("_LoginUser"));
        }
    }
}

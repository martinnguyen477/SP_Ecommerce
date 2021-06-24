using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        private ICustomerService _customerService;
        public CommentViewComponent(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        public Task<IViewComponentResult> InvokeAsync(string bookId)
        {
            CommentEditModel mdl = new CommentEditModel();
            mdl.BookId = bookId;
            if (User.Identity.IsAuthenticated)
            {
                mdl.Name = User.Identity.Name;
                mdl.BookId = bookId;
                try
                {
                    var customerId = UserClaimsPrincipal.FindFirst("Id").Value;
                    Customer customer = _customerService.GetCustomer(customerId);
                    mdl.Email = customer.Email;
                }
                catch (Exception)
                {
                    mdl.Email = "";
                }
            }

            return Task.FromResult<IViewComponentResult>(View("CommentView", mdl));
        }
    }

}

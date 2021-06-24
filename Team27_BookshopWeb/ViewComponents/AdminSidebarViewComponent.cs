using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.ViewComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        public AdminSidebarViewComponent()
        {}

        public Task<IViewComponentResult> InvokeAsync()
        {
            string pageUrl = Request.Path.ToString();
            return Task.FromResult<IViewComponentResult>(View("AdminSidebar", pageUrl));
        }
    }
}

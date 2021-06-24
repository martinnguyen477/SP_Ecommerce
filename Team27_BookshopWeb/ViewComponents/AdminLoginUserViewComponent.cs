using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{

    public class AdminLoginUserViewComponent : ViewComponent
    {
        private IEmployeeService _employeeService;

        public AdminLoginUserViewComponent(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                string id = UserClaimsPrincipal.FindFirst("Id").Value;
                Employee employee = _employeeService.GetEmployee(id);
                ViewBag.Name = employee.DisplayName;
                ViewBag.Gender = employee.Gender;
                ViewBag.UserEmail = employee.Email;
                
            }
            
            return Task.FromResult<IViewComponentResult>(View("_AdminLoginUser"));
        }

    }

}

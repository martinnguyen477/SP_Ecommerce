using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class ProfileController : Controller
    {
        private IEmployeeService _employeeService;
        public ProfileController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string id = User.FindFirst("Id").Value;
                Employee employee = _employeeService.GetEmployee(id);
                EmployeeProfileEditModel mdl = _employeeService.EmployeeToProfileModel(employee);
                //Nhận thông báo
                if (TempData.Get<MessagesViewModel>("MessagesView") != null)
                {
                    mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
                }
                return View(mdl);
            }
            return RedirectToAction("Login", "Employee");
            
        }

        [HttpPost]
        public IActionResult EditAccount(EmployeeProfileEditModel employee)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _employeeService.EditEmployee(_employeeService.ProfileModelToEditModel(employee));
                //Gửi thông báo
                TempData.Put("MessagesView", mdl);
                return RedirectToAction("Index");
            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult EditPassword(string id, string newPassword)
        {
            return Json(_employeeService.EditEmployeePassword(id, newPassword));
        }

        [HttpPost]
        public JsonResult EmailVerify(string Email, string id)
        {
            if (_employeeService.EmailValidation(Email, id) == false)
                return Json("Email đã được sử dụng");
            return Json(true);
        }

        [HttpPost]
        public JsonResult UsernameVerify(string username, string id)
        {
            if (_employeeService.UsernameValidation(username, id) == false)
                return Json("Tên đăng nhập đã được sử dụng");
            return Json(true);
        }

        public JsonResult PasswordCheck(string id, string pass)
        {
            return Json(_employeeService.PasswordCheck(id, pass));
        }
    }
}
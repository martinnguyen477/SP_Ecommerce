using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    //[Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(MyDbContext context, IEmployeeService employeeService)
        {
            _context = context;
            _employeeService = employeeService;
        }
        
        public IActionResult Index(string name, string position, int page=1)
        {
            EmployeeViewModel nv = new EmployeeViewModel();
            nv.ChucVu = _employeeService.FilterByPosition();
            nv.name = name;
            nv.position = position;

            IQueryable<Employee> res;
            if (!String.IsNullOrEmpty(name)) //thực hiện tìm kiếm
            {
                res = _employeeService.FindName(name,_context.Employees);
            }
            else
            {
                res = _employeeService.Fliter("All", _context.Employees);
                
            }

            res = _employeeService.Fliter(position, res);
            nv.employees = res.ToList();
            nv = PaginationInfo(nv, page);
            nv.employees = Paging(nv.employees, page);

            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                nv.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }

            return View(nv);
        }

        public IActionResult Create()
        {
            EmployeeEditModel nv = new EmployeeEditModel();
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                nv.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(nv);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeEditModel nvEM)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _employeeService.CreateEmployee(nvEM);
                TempData.Put("MessagesView", res);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            //Gửi thông báo thất bại
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ!"));
            return RedirectToAction("Create");
        }

        public IActionResult Edit(string id)
        {
            EmployeeEditModel nvEM = new EmployeeEditModel();
            Employee e = _employeeService.GetEmployee(id); // kiểu employee
            if (e == null)
            {
                //Gửi thông báo thất bại

                TempData.Put("MessagesView", new MessagesViewModel(false, "Nhân viên yêu cầu không tồn tại"));
                return RedirectToAction("Index");
            }
            nvEM = _employeeService.EmployeeToEditModel(e);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                nvEM.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(nvEM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeEditModel employeeEdit)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _employeeService.EditEmployee(employeeEdit);
                TempData.Put("MessagesView", res);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }
            //Gửi thông báo thất bại

            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ!"));
            return RedirectToAction("Edit");
        }

        [HttpGet]
        public JsonResult DeleteAjax(string id)
        {
            MessagesViewModel res = new MessagesViewModel();
            res = _employeeService.Delete(id);
            return Json(res); // trả về 1 chuỗi key-value
        }
        
        [AllowAnonymous, HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {
            LoginViewModel loginRegister = new LoginViewModel();
            ViewBag.ReturnUrl = ReturnUrl;
            //Nhận thông báo 
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                ViewBag.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(loginRegister);
        }

        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string ReturnUrl = null)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ReturnUrl = ReturnUrl;

                MessagesViewModel auth = _employeeService.EmployeeAuthentication(login);
                if (!auth.IsSuccess)
                {
                    TempData.Put("MessagesView", auth);
                    return RedirectToAction("Login");
                }
                Employee user = (Employee)auth.Data;

                try
                {
                    //Tạo principal
                    ClaimsPrincipal principal = _employeeService.CreateEmployeePrincipal(user);
                    await HttpContext.SignInAsync("admin", principal);
                    //Gán session
                    HttpContext.Session.SetString("EmployeeId", user.Id);

                    //Lấy lại trang yêu cầu (nếu có)
                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard");//default
                    }
                }
                catch (Exception)
                {
                    TempData.Put("MessagesView", new MessagesViewModel(false, "Đăng nhập thất bại"));
                    return RedirectToAction("Login");
                }
            }
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin đăng nhập không hợp lệ"));
            return RedirectToAction("Login");

        }

        [AllowAnonymous]
        [Route("/admin/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("admin");
            HttpContext.Session.Remove("EmployeeId");
            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        [Route("/admin/access-denied")]
        public IActionResult AccessDenied()
        {
            return View("/Views/Shared/AccessDenied.cshtml", "/admin/login");
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Employee> Paging(IEnumerable<Employee> employees, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            employees = employees.Skip(skipN).Take(PAGE_SIZE);
            return employees;
        }

        public EmployeeViewModel PaginationInfo(EmployeeViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.employees.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}

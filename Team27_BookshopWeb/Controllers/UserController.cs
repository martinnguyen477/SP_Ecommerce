using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;
using BC = BCrypt.Net.BCrypt;

namespace Team27_BookshopWeb.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly MyDbContext _myDbContext;
        private readonly ICustomerService _customerService;
        private readonly IOrdersService _ordersService;

        public UserController(MyDbContext myDbContext, ICustomerService customerService, IOrdersService ordersService)
        {
            _myDbContext = myDbContext;
            _customerService = customerService;
            _ordersService = ordersService;
        }

        [AllowAnonymous, HttpGet]
        public IActionResult Register(string ReturnUrl = null)
        {
            LoginRegisterViewModel loginRegister = new LoginRegisterViewModel();
            ViewBag.ReturnUrl = ReturnUrl;
            //Nhận thông báo 
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                loginRegister.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(loginRegister);
        }

        [AllowAnonymous, HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                CustomerEditModel customerEdit = _customerService.RegisterUserToCustomerEdit(register);
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _customerService.CreateCustomer(customerEdit);
                //Gửi thông báo
                TempData.Put("MessagesView", mdl);
                return RedirectToAction("Register");
            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Register");
        }

        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string ReturnUrl = null)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ReturnUrl = ReturnUrl;

                MessagesViewModel auth = _customerService.CustomerAuthentication(login);
                if (!auth.IsSuccess)
                {
                    TempData.Put("MessagesView", auth);
                    return RedirectToAction("Register");
                }
                Customer user = (Customer)auth.Data;

                try
                {
                    //Tạo principal
                    ClaimsPrincipal principal = _customerService.CreateCustomerPrincipal(user);
                    await HttpContext.SignInAsync(principal);
                    //Gán session
                    HttpContext.Session.SetString("CustomerId", user.Id);

                    //Lấy lại trang yêu cầu (nếu có)
                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");//default
                    }
                }
                catch (Exception)
                {
                    TempData.Put("MessagesView", new MessagesViewModel(false, "Đăng nhập thất bại"));
                    return RedirectToAction("Register");
                }
            }
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin đăng nhập không hợp lệ"));
            return RedirectToAction("Register");

        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Register");
        }

        [Route("/access-denied")]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View("~Views/Shared/AccessDenied.cshtml", "/login");
        }

        [HttpGet]
        [Route("/my-account/profile")]
        public IActionResult Profile()
        {
            CustomerEditModel customerEdit = new CustomerEditModel();
            if (User.Identity.IsAuthenticated)
            {
                //Lấy ra id của khách hàng đang đăng nhập
                string id = User.FindFirst("Id").Value;
                Customer customer = _customerService.GetCustomer(id);
                customerEdit = _customerService.CustomerToEditModel(customer);
                //Nhận thông báo
                if (TempData.Get<MessagesViewModel>("MessagesView") != null)
                {
                    customerEdit.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
                }
                return View(customerEdit);
            }
            return RedirectToAction("Register");
        }

        [HttpGet]
        [Route("/my-account/dashboard")]
        public IActionResult Dashboard()
        {
            if (User.Identity.IsAuthenticated)
            {
                string id = User.FindFirst("Id").Value;
                Customer customer = _customerService.GetCustomer(id);
                string name = customer.DisplayName;
                return View("Dashboard", name);
            }
            return RedirectToAction("Register");
        }

        [HttpPost]
        public IActionResult EditAccount(CustomerEditModel customer)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _customerService.EditCustomer(customer);
                //Gửi thông báo
                TempData.Put("MessagesView", mdl);
                return RedirectToAction("Profile");
            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Profile");
        }
        [HttpPost]
        public JsonResult EditPassword(string id, string newPassword)
        {
            return Json(_customerService.EditCustomerPassword(id, newPassword));
        }

        [HttpGet]
        [Route("/my-account/history")]
        public IActionResult History()
        {
            if (User.Identity.IsAuthenticated)
            {
                string id = User.FindFirst("Id").Value;
                OrderViewModel mdl = new OrderViewModel();
                mdl.Orders = _ordersService.GetOrdersByCustomerId(id);
                return View(mdl);
            }
            return RedirectToAction("Register");
        }

        public JsonResult UpdateStatus(string id)
        {
            MessagesViewModel messagesViewModel = new MessagesViewModel();
            messagesViewModel = _ordersService.UpdateOrder(id, 5);
            return Json(messagesViewModel);
        }

        [Route("/my-account/wishlist")]
        public IActionResult Wishlist()
        {
            IEnumerable<Wishlist> wishlists = Enumerable.Empty<Wishlist>();
            if (User.Identity.IsAuthenticated)
            {
                string customerId = User.FindFirst("Id").Value;
                wishlists = _customerService.GetWishlists(customerId);
            }
            return View(wishlists);
        }

        public JsonResult HandleWishlist(string bookId)
        {
            if (User.Identity.IsAuthenticated)
            {
                string customerId = User.FindFirst("Id").Value;
                return Json(_customerService.HandleWishlist(customerId, bookId));
            }
            return Json(new MessagesViewModel(false, "Người dùng chưa đăng nhập"));
        }


        [AllowAnonymous, HttpPost]
        public JsonResult EmailVerify(string email, string id)
        {
            if (_customerService.EmailValidation(email, id) == false)
                return Json("Email đã được sử dụng");
            return Json(true);
        }

        [AllowAnonymous, HttpPost]

        public JsonResult UsernameVerify(string username, string id)
        {
            if (_customerService.UsernameValidation(username, id) == false)
                return Json("Tên đăng nhập đã được sử dụng");
            return Json(true);
        }

        public JsonResult PasswordCheck(string id, string pass)
        {
            return Json(_customerService.PasswordCheck(id, pass));
        }
    }
}
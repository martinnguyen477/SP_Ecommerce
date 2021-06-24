using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly MyDbContext myDbContext;
        private readonly IOrdersService _ordersService;
        private readonly ICustomerService _customerService;
        private readonly ICartsService _cartsService;

        public CheckoutController(MyDbContext _myDbContext,
                                IOrdersService ordersService,
                                ICustomerService customerService,
                                ICartsService cartsService)
        {
            this.myDbContext = _myDbContext;
            this._ordersService = ordersService;
            this._customerService = customerService;
            this._cartsService = cartsService;
        }

        [Route("/thanh-toan")]
        public IActionResult Index()
        {
            CheckoutViewModel mdl = new CheckoutViewModel();
            Cart cart;
            if (User.Identity.IsAuthenticated)
            {
                var customerId = User.FindFirst("Id").Value;
                Customer customer = _customerService.GetCustomer(customerId);
                mdl.Name = customer.DisplayName;
                mdl.Phone = customer.Phone;
                mdl.Email = customer.Email;
                mdl.Address = customer.Address;
                mdl.Cart = _cartsService.GetCartByCustomer(customerId);
            }
            else
            {
                if (HttpContext.Request.Cookies["cart"] != null)
                {
                    var cartId = int.Parse(HttpContext.Request.Cookies["cart"]);
                    mdl.Cart = _cartsService.GetCart(cartId);
                    
                }
            }

            if (mdl.Cart != null)
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                mdl.CartItems = _cartsService.GetCheckoutItems(mdl.Cart.Id);
                if (mdl.CartItems.Count() > 0)
                {
                    mdl.SubTotal = mdl.CartItems.Sum(ci => ci.Total);
                }
            }
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }

        [Route("/hoan-tat-thanh-toan/{orderId}")]
        public IActionResult OrderComplete(string orderId)
        {
            return View(_ordersService.GetOrderWithDetail(orderId));
        }

        public IActionResult PlaceOrder(CheckoutViewModel checkoutView)
        {
            if (ModelState.IsValid)
            {
                Cart cart = new Cart();
                var customerId = "";
                if (User.Identity.IsAuthenticated)
                {
                    customerId = User.FindFirst("Id").Value;
                    cart = _cartsService.GetCartByCustomer(customerId);
                }
                else
                {
                    if (HttpContext.Request.Cookies["cart"] != null)
                    {
                        var cartId = int.Parse(HttpContext.Request.Cookies["cart"]);
                        cart = _cartsService.GetCart(cartId);
                    }
                }

                if (cart == null) return RedirectToAction("Index");
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _ordersService.PlaceOrder(checkoutView, customerId, cart);
                
                if (mdl.IsSuccess)
                {
                    return Redirect("/hoan-tat-thanh-toan/" + mdl.Data);
                }
                //Gửi thông báo
                TempData.Put("MessagesView", mdl);
                return RedirectToAction("Index");
            }

            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Index");
        }

        public JsonResult ApplyCoupon(string code)
        {
            return Json(_ordersService.ApplyCoupon(code));
        }
    }
}
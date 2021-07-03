using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Controllers
{
    public class CartController : Controller
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICartsService _cartsService;

        public CartController(MyDbContext _myDbContext,
                                IBooksService booksService, 
                                ICartsService cartsService,
                                IHttpContextAccessor httpContextAccessor)
        {
            this.myDbContext = _myDbContext;
            this._booksService = booksService;
            this._cartsService = cartsService;
            this._httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            CartViewModel cart = new CartViewModel();
            if (User.Identity.IsAuthenticated)
            {
                string customerId = User.FindFirst("Id").Value;
                if (!string.IsNullOrEmpty(customerId))
                {
                    cart.Cart = _cartsService.WhereCustomerId(customerId, _cartsService.QueryNotDeletedCart()).FirstOrDefault();
                }
            }
            else
            {
                if (_httpContextAccessor.HttpContext.Request.Cookies["cart"] != null)
                {
                    cart.Cart = _cartsService.GetCart(int.Parse(_httpContextAccessor.HttpContext.Request.Cookies["cart"]));
                }
            }

            if (cart.Cart != null)
            {
                cart.CartItems = _cartsService.GetCartItems(cart.Cart.Id);
            }
            cart.ConsideredBooks = _booksService.GetConsideredBooks();
            return View(cart);
        }

        public IActionResult RemoveCartItem(string bookId)
        {
            string customerId = "";
            if (User.Identity.IsAuthenticated)
            {
                customerId = User.FindFirst("Id").Value;
            }
            MessagesViewModel mdl = new MessagesViewModel();
            mdl = _cartsService.RemoveCartItem(bookId, customerId);
            if (!mdl.IsSuccess)
            {
                return Json(mdl);
            }
            else
            {
                return ViewComponent("CartBlock");
            }
        }

        public IActionResult HandleCart(string bookId, int quantity)
        {
            string customerId = "";
            if (User.Identity.IsAuthenticated)
            {
                customerId = User.FindFirst("Id").Value;
            }
            MessagesViewModel mdl = new MessagesViewModel();
            mdl = _cartsService.HandleCart(bookId, quantity, customerId);
            if (!mdl.IsSuccess || mdl.Messages.First() == "Add")
            {
                return Json(mdl);
            }
            else
            {
                return ViewComponent("CartBlock");
            }
        }

        public IActionResult LoadCartBlock()
        {
            return ViewComponent("CartBlock");
        }

        public JsonResult SelectCheckoutItem(string bookId, int select)
        {
            Cart cart = GetCurrentCart();
            return Json(_cartsService.SelectCheckoutItem(cart.Id, bookId, select));
        }

        public Cart GetCurrentCart()
        {
            Cart cart = new Cart();
            if (User.Identity.IsAuthenticated)
            {
                string customerId = User.FindFirst("Id").Value;
                if (!string.IsNullOrEmpty(customerId))
                {
                    cart = _cartsService.WhereCustomerId(customerId, _cartsService.QueryNotDeletedCart()).FirstOrDefault();
                }
            }
            else
            {
                cart = _cartsService.GetCart(int.Parse(_httpContextAccessor.HttpContext.Request.Cookies["cart"]));
            }

            return cart;
        }

    }
}
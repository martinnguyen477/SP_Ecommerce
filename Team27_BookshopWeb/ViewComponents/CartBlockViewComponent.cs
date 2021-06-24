using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class CartBlockViewComponent : ViewComponent
    {
        private readonly MyDbContext _myDbContext;
        private readonly ICartsService _cartsService;
        public CartBlockViewComponent(MyDbContext myDbContext, ICartsService cartsService)
        {
            this._myDbContext = myDbContext;
            this._cartsService = cartsService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            CartViewModel cart = new CartViewModel();
            int cartId = 0;
            //Lấy giỏ hàng
            //Đã đăng nhập
            if (User.Identity.IsAuthenticated)
            {
                string customerId = UserClaimsPrincipal.FindFirst("Id").Value;
                if (!string.IsNullOrEmpty(customerId))
                {
                    cart.Cart = _cartsService.GetCartByCustomer(customerId);
                }
            }
            else
            {
                //Không đăng nhập
                try
                {
                    if (HttpContext.Request.Cookies["cart"] != null)
                    {
                        cartId = int.Parse(HttpContext.Request.Cookies["cart"]);
                    }
                    
                    cart.Cart = _cartsService.GetCart(cartId);
                }
                catch (Exception)
                {
                    cart.Cart = null;
                }
                
            }

            //Lấy chi tiết giỏ hàng
            if (cart.Cart != null)
            {
                cart.CartItems = _cartsService.GetCartItems(cart.Cart.Id);
            }

            return Task.FromResult<IViewComponentResult>(View("CartBlock", cart));
        }
    }
}

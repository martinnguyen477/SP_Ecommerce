using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.PayPalHelper;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Controllers
{
   
    public class CheckoutController : Controller
    {
        private readonly MyDbContext myDbContext;
        private readonly IOrdersService _ordersService;
        private readonly ICustomerService _customerService;
        private readonly ICartsService _cartsService;
        public IConfiguration _configuration { get; }


        public CheckoutController(MyDbContext _myDbContext,
                                IOrdersService ordersService,
                                ICustomerService customerService,
                                ICartsService cartsService, IConfiguration configuration)
        {
            this.myDbContext = _myDbContext;
            this._ordersService = ordersService;
            this._customerService = customerService;
            this._cartsService = cartsService;
            _configuration = configuration;
        }
        #region Index Thanh Toán

        [Route("/thanh-toan")]
        public IActionResult Index()
        {
            ViewBag.PaymentMethod = myDbContext.PaymentMethods.ToList();
            CheckoutViewModel mdl = new CheckoutViewModel();
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
        #endregion

        #region Hoàn tất thanh toán
        [Route("/hoan-tat-thanh-toan/{orderId}")]
        public IActionResult OrderComplete(string orderId)
        {
            return View(_ordersService.GetOrderWithDetail(orderId));
        }
        #endregion

        [Route("PlaceOrder")]
        [HttpPost]
        public async Task<IActionResult> PlaceOrder(CheckoutViewModel checkoutView)
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
                if(checkoutView.PaymentMethod == 2)
                {
                    _ordersService.PlaceOrder(checkoutView, customerId, cart, 1);
                    var paypalAPI = new PayPalAPI(_configuration);
                    string url = await paypalAPI.getRedirectURLtoPayPal(checkoutView.SubTotal, "USD");
                    return Redirect(url);
                }    
                mdl = _ordersService.PlaceOrder(checkoutView, customerId, cart, checkoutView.PaymentMethod);
                
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

       
        public async Task<IActionResult> Success([FromQuery(Name = "PaymentId")] string paymentId, [FromQuery(Name = "PayerId")] string payerId, CheckoutViewModel checkoutViewModel)
        {
            var paypalAPI = new PayPalAPI(_configuration);
            PayPalPaymentExecutedResponse result = await paypalAPI.executedPayment(paymentId, payerId);

            var order = _ordersService.GetAllOrders().LastOrDefault();
            MessagesViewModel mdl = new MessagesViewModel();
            _ordersService.UpdateOrderByPayPal(order.Id, 2);
            Debug.WriteLine("Transaction Details");
            Debug.WriteLine("Cart:" + result.cart);
            Debug.WriteLine("Create_time:" + result.create_time.ToString());
            Debug.WriteLine("Id:" + result.id);
            Debug.WriteLine("Intent:" + result.intent);
            Debug.WriteLine("Link 0 - href: " + result.links[0].href);
            Debug.WriteLine("Link 0 - method:" + result.links[0].method);
            Debug.WriteLine("Link 0 - rel" + result.links[0].rel);
            Debug.WriteLine("Payer_info - first_name" + result.payer.payer_info.first_name);
            Debug.WriteLine("Payer_info - last_name" + result.payer.payer_info.last_name);
            Debug.WriteLine("Payer_info - email:" + result.payer.payer_info.email);
            Debug.WriteLine("Payer_info - billing_address" + result.payer.payer_info.billing_address);
            Debug.WriteLine("Payer_info - country_code" + result.payer.payer_info.country_code);
            Debug.WriteLine("Payer_info - shipping_adress" + result.payer.payer_info.shipping_address);
            Debug.WriteLine("Payer_info -payer_ID" + result.payer.payer_info.payer_id);
            Debug.WriteLine("State:" + result.state);
            ViewBag.result = result;

            return await Task.Run<ActionResult>(() =>
            {
                return Redirect("/hoan-tat-thanh-toan/" + order.Id);
            });
        }

        public JsonResult ApplyCoupon(string code)
        {
            return Json(_ordersService.ApplyCoupon(code));
        }
    }
}
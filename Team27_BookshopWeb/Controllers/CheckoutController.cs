using System;
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
using Team27_BookshopWeb.VNPayHelper;
using System.Collections.Generic;

namespace Team27_BookshopWeb.Controllers
{
   
    public class CheckoutController : Controller
    {
        private readonly MyDbContext myDbContext;
        private readonly IOrdersService _ordersService;
        private readonly ICustomerService _customerService;
        private readonly ICartsService _cartsService;
        private readonly string _url;
        private readonly string _returnUrl;
        private readonly string _tmnCode;
        private readonly string _hashSecret;

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
            _url = configuration["VNPay:Url"];
            _returnUrl = configuration["VNPay:ReturnUrl"];
            _tmnCode = configuration["VNPay:TmnCode"];
            _hashSecret = configuration["VNPay:HashSecret"];
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

        /// <summary>
        /// đặt hàng.
        /// </summary>
        /// <param name="checkoutView"></param>
        /// <returns></returns>
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
                if(checkoutView.PaymentMethod == 3)
                {
                    _ordersService.PlaceOrder(checkoutView, customerId, cart, 3);
                    var paymentVNPay = new PayLib();
                    string money = (checkoutView.SubTotal * 100 ).ToString();
                    paymentVNPay.AddRequestData("vnp_Version", "2.0.0"); //Phiên bản api mà merchant kết nối. Phiên bản hiện tại là 2.0.0
                    paymentVNPay.AddRequestData("vnp_Command", "pay"); //Mã API sử dụng, mã cho giao dịch thanh toán là 'pay'
                    paymentVNPay.AddRequestData("vnp_TmnCode", _tmnCode); //Mã website của merchant trên hệ thống của VNPAY (khi đăng ký tài khoản sẽ có trong mail VNPAY gửi về)
                    paymentVNPay.AddRequestData("vnp_Amount", money); //số tiền cần thanh toán, công thức: số tiền * 100 - ví dụ 10.000 (mười nghìn đồng) --> 1000000
                    paymentVNPay.AddRequestData("vnp_BankCode", ""); //Mã Ngân hàng thanh toán (tham khảo: https://sandbox.vnpayment.vn/apis/danh-sach-ngan-hang/), có thể để trống, người dùng có thể chọn trên cổng thanh toán VNPAY
                    paymentVNPay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss")); //ngày thanh toán theo định dạng yyyyMMddHHmmss
                    paymentVNPay.AddRequestData("vnp_CurrCode", "VND"); //Đơn vị tiền tệ sử dụng thanh toán. Hiện tại chỉ hỗ trợ VND
                   // paymentVNPay.AddRequestData("vnp_IpAddr", Util.GetIpAddress()); //Địa chỉ IP của khách hàng thực hiện giao dịch
                    paymentVNPay.AddRequestData("vnp_Locale", "vn"); //Ngôn ngữ giao diện hiển thị - Tiếng Việt (vn), Tiếng Anh (en)
                    paymentVNPay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang"); //Thông tin mô tả nội dung thanh toán
                    paymentVNPay.AddRequestData("vnp_OrderType", "other"); //topup: Nạp tiền điện thoại - billpayment: Thanh toán hóa đơn - fashion: Thời trang - other: Thanh toán trực tuyến
                    paymentVNPay.AddRequestData("vnp_ReturnUrl", _returnUrl); //URL thông báo kết quả giao dịch khi Khách hàng kết thúc thanh toán
                    paymentVNPay.AddRequestData("vnp_TxnRef", DateTime.Now.Ticks.ToString()); //mã hóa đơn
                    string paymentUrl = paymentVNPay.CreateRequestUrl(_url, _hashSecret);

                    return Redirect(paymentUrl);
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
        public IActionResult PaymentError([FromQuery(Name = "PaymentId")] string paymentId, [FromQuery(Name = "PayerId")] string payerId, CheckoutViewModel checkoutViewModel)
        {
            var order = _ordersService.GetAllOrders().LastOrDefault();
            myDbContext.Orders.Remove(order);
            return View();
        }

        public ActionResult PaymentConfirm([FromQuery(Name = "vnp_Amount")] string vnp_Amount, 
            [FromQuery(Name = "vnp_BankCode")] string vnp_BankCode, 
            [FromQuery(Name = "vnp_BankTranNo")] string vnp_BankTranNo,
            [FromQuery(Name = "vnp_CardType")] string vnp_CardType, 
            [FromQuery(Name = "vnp_OrderInfo")] string vnp_OrderInfo,
            [FromQuery(Name = "vnp_PayDate")] string vnp_PayDate,
            [FromQuery(Name = "vnp_ResponseCode")] string vnp_ResponseCode,
            [FromQuery(Name = "vnp_TmnCode")] string vnp_TmnCode,
            [FromQuery(Name = "vnp_TransactionNo")] string vnp_TransactionNo,
            [FromQuery(Name = "vnp_TxnRef")] string vnp_TxnRef,
            [FromQuery(Name = "vnp_SecureHashType")] string vnp_SecureHashType,
            [FromQuery(Name = "vnp_SecureHash")] string vnp_SecureHash, CheckoutViewModel checkoutViewModel)
            {
                var order = _ordersService.GetAllOrders().LastOrDefault();
                var vnpayData = Request;
                PayLib pay = new PayLib();
                pay.AddResponseData("vnp_Amount", vnp_Amount);
                pay.AddResponseData("vnp_BankCode", vnp_BankCode);
                pay.AddResponseData("vnp_BankTranNo", vnp_BankTranNo );
                pay.AddResponseData("vnp_CardType", vnp_CardType );
                pay.AddResponseData("vnp_OrderInfo", vnp_OrderInfo);
                pay.AddResponseData("vnp_PayDate", vnp_PayDate);
                pay.AddResponseData("vnp_ResponseCode", vnp_ResponseCode);
                pay.AddResponseData("vnp_TmnCode", vnp_TmnCode);
                pay.AddResponseData("vnp_TransactionNo", vnp_TransactionNo);
                pay.AddResponseData("vnp_TxnRef", vnp_TxnRef);
                pay.AddResponseData("vnp_SecureHashType", vnp_SecureHashType);
                pay.AddResponseData("vnp_SecureHash", vnp_SecureHash);

                long orderId = Convert.ToInt64(vnp_TxnRef); //mã hóa đơn
                long vnpayTranId = Convert.ToInt64(vnp_TransactionNo); //mã giao dịch tại hệ thống VNPAY
                bool checkSignature = pay.ValidateSignature(vnp_SecureHash, _hashSecret); //check chữ ký đúng hay không?

                if (checkSignature)
                {
                    if (vnp_ResponseCode == "00")
                    {
                        //Thanh toán thành công
                        ViewBag.Message = "Thanh toán thành công hóa đơn " + orderId + " | Mã giao dịch: " + vnpayTranId;
                         
                        _ordersService.UpdateOrderByPayPal(order.Id, 3);
                        return Redirect("/hoan-tat-thanh-toan/" + order.Id);
                    }
                    else
                    {
                        //Thanh toán không thành công. Mã lỗi: vnp_ResponseCode
                        ViewBag.Message = "Có lỗi xảy ra trong quá trình xử lý hóa đơn " + orderId + " | Mã giao dịch: " + vnpayTranId + " | Mã lỗi: " + vnp_ResponseCode;
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Có lỗi xảy ra trong quá trình xử lý";
                    return View();
                }
            
        }

    public JsonResult ApplyCoupon(string code)
        {
            return Json(_ordersService.ApplyCoupon(code));
        }
    }
}
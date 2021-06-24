using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public class PaymentMethodController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IPaymentService _paymentService;

        public PaymentMethodController(MyDbContext context, IPaymentService paymentService)
        {
            _context = context;
            _paymentService = paymentService;
        }
        public IActionResult Index(string filter)
        {
            PaymentMethodViewModel pm = new PaymentMethodViewModel();
            pm.filter = filter;
            IQueryable<PaymentMethod> res;
            res = _paymentService.Fliter(filter, _context.PaymentMethods);
            pm.payments = res.ToList();

            //Nhận thông báos
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                pm.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
           // pm.payments = _paymentService.ListPaymentMethod();
            return View(pm);
        }

        public IActionResult Create()
        {
            PaymentMethodEditModel pm = new PaymentMethodEditModel();
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                pm.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(pm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentMethodEditModel pmEM)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _paymentService.CreatePayment(pmEM);
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

        public IActionResult Edit(int id)
        {
            PaymentMethodEditModel pmEM = new PaymentMethodEditModel();
            PaymentMethod p = _paymentService.GetPayment(id); // kiểu payment
            if (p == null)
            {
                //Gửi thông báo thất bại

                TempData.Put("MessagesView", new MessagesViewModel(false, "Phương thức thanh toán yêu cầu không tồn tại"));
                return RedirectToAction("Index");
            }
            pmEM = _paymentService.PaymentToEditModel(p);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                pmEM.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(pmEM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PaymentMethodEditModel payment)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _paymentService.EditPayment(payment);
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
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Services;
using Team27_BookshopWeb.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class CustomerController : Controller
    {
        private readonly MyDbContext _context;
        private readonly ICustomerService _customerService;

        public CustomerController(MyDbContext context, ICustomerService customerService)
        {
            _context = context;
            _customerService = customerService;
        }

        public IActionResult Index(string search, string function, string hiddenFunc, int page=1)
        {
            CustomerViewModel mdl = new CustomerViewModel();
            mdl.search = search;
            if (search != null)
            {
                mdl.FindCustomer = search;
                if (function == "Danh sách đã xóa" || hiddenFunc == "Danh sách đã xóa")
                {
                    mdl.customers = _customerService.FindDeletedCustomerName(search);
                    mdl.DeleteCustomer = "Danh sách đã xóa";
                }
                else 
                {
                    mdl.customers = _customerService.FindCustomerName(search);
                }
                          }
            else // name == null -- không sử dụng tìm kiếm
            {
                if(function == "Danh sách đã xóa")
                {
                    mdl.customers = _customerService.ListDeletedTmpCustomer();
                    mdl.DeleteCustomer = function;
                }
                else
                {
                    mdl.customers = _customerService.ListCustomer();
                }
                
            }
            mdl = PaginationInfo(mdl, page);
            mdl.customers = Paging(mdl.customers, page);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl); 
        }

        public IActionResult Create()
        {
            CustomerEditModel khEM = new CustomerEditModel();
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                khEM.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(khEM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerEditModel khEM)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _customerService.CreateCustomer(khEM);
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
            CustomerEditModel khEM = new CustomerEditModel();
            Customer cs = _customerService.GetCustomer(id); // kiểu customer
            if(cs == null)
            {
                //Gửi thông báo thất bại

                TempData.Put("MessagesView", new MessagesViewModel(false, "Khách hàng yêu cầu không tồn tại"));
                return RedirectToAction("Index");
            }
            khEM = _customerService.CustomerToEditModel(cs);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                khEM.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(khEM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerEditModel customerEdit)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _customerService.EditCustomer(customerEdit);
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

        public IActionResult DeleteTmp(string id)
        {

            MessagesViewModel res = _customerService.DeleteCustomerTmp(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public IActionResult Delete(string id)
        {
            MessagesViewModel res = _customerService.Delete(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        public IActionResult Restore(string id)
        {
            MessagesViewModel res = _customerService.Restore(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Customer> Paging(IEnumerable<Customer> customers, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            customers = customers.Skip(skipN).Take(PAGE_SIZE);
            return customers;
        }

        public CustomerViewModel PaginationInfo(CustomerViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.customers.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }

    }
}
    
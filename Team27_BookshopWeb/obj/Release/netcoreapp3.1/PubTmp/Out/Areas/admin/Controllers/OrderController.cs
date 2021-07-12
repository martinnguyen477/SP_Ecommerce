using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class OrderController : Controller
    {
        private readonly MyDbContext _myDbContext;
        private readonly IOrdersService _ordersService;

        public OrderController(MyDbContext myDbContext, IOrdersService ordersService)
        {
            _myDbContext = myDbContext;
            _ordersService = ordersService;
        }
        public IActionResult Index(int searchtype, string search, DateTime fromdate, DateTime todate, string filtertype, int filter, int page=1)
        {
            OrderViewModel mdl = new OrderViewModel();
            IQueryable<Order> orders = _ordersService.QueryAllOrders();
            switch (searchtype)
            {
                case 1:
                    orders = _ordersService.WhereId(search, orders);
                    break;
                case 2:
                    orders = _ordersService.WhereCustomerName(search, orders);
                    break;
                case 3:
                    orders = _ordersService.WhereBetweenDate(fromdate, todate, orders);
                    break;
                default:
                    break;
            }
            //Filter
            switch(filtertype)
            {
                case "OrderStatus":
                    orders = _ordersService.WhereOrderStatus(filter, orders);
                    break;
                case "PaymentMethod":
                    orders = _ordersService.WherePaymentMethod(filter, orders);
                    break;
                default:
                    break;
            }
            mdl.Orders = orders.ToList();
            mdl = PaginationInfo(mdl, page);
            mdl.Orders = Paging(mdl.Orders, page);
            mdl.searchtype = searchtype;
            mdl.search = search;
            mdl.fromdate = fromdate;
            mdl.todate = todate;
            mdl.filtertype = filtertype;
            mdl.filter = filter;
            return View(mdl);
        }

        [AllowAnonymous]
        public IActionResult Details(string Id)
        {
            OrderDetailViewModel mdl = new OrderDetailViewModel();
            mdl.Order = _ordersService.GetOrder(Id);
            mdl.OrderDetails = _ordersService.GetOrderDetails(Id);
            return PartialView("_OrderDetailView", mdl);
        }

        public JsonResult UpdateStatus(string id, int status)
        {
            MessagesViewModel messagesViewModel = new MessagesViewModel();
            messagesViewModel = _ordersService.UpdateOrder(id, status);
            return Json(messagesViewModel);
        }

        public IActionResult GetFilter(string filterType, int filter)
        {
            if (filterType != "Default")
            {
                ViewBag.filter = filter;
                return PartialView("_Filter", _ordersService.GetFilter(filterType));
            }
            return null;
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Order> Paging(IEnumerable<Order> orders, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            orders = orders.Skip(skipN).Take(PAGE_SIZE);
            return orders;
        }

        public OrderViewModel PaginationInfo(OrderViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.Orders.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class OrderStatusSelectViewComponent : ViewComponent
    {
        private readonly MyDbContext myDbContext;
        private readonly IOrdersService _ordersService;
        
        public OrderStatusSelectViewComponent(MyDbContext myDbContext, IOrdersService ordersService)
        {
            this.myDbContext = myDbContext;
            _ordersService = ordersService;
        }
        public Task<IViewComponentResult> InvokeAsync(Order order)
        {
            var orderStatuses = myDbContext.OrderStatuses.ToList();
            ViewBag.StatusId = order.StatusId;
            ViewBag.OrderId = order.Id;
            return Task.FromResult<IViewComponentResult>(View("OrderStatusSelect", orderStatuses));
        }
    }
}

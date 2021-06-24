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
    public class CouponSidebarViewComponent : ViewComponent
    {
        private readonly MyDbContext myDbContext;
        private readonly ICouponService _couponService;
        public CouponSidebarViewComponent(MyDbContext myDbContext, ICouponService couponService)
        {
            this.myDbContext = myDbContext;
            this._couponService = couponService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            CouponSidebarViewModel sidebar = new CouponSidebarViewModel();
            sidebar.NewCoupons = _couponService.GetNewCoupons().Take(4);
            sidebar.CouponTypes = _couponService.AllTypes();
            return Task.FromResult<IViewComponentResult>(View("CouponSidebar", sidebar));
        }
    }
}

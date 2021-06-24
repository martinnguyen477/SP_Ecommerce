using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Models
{
    public class CouponSidebarViewModel { 
        public IEnumerable<String> CouponTypes { get; set; }
        public IEnumerable<Coupon> NewCoupons { get; set; }
    }
}

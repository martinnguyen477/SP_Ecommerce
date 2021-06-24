using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class CouponGalleryViewModel
    {
        public IEnumerable<Coupon> Coupons { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

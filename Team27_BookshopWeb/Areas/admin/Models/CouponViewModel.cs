using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class CouponViewModel
    {
        public string timKiem { get; set; }
        public string thongBao { get; set; }
        public IEnumerable<Coupon> coupons { get; set; }

        public MessagesViewModel MessagesView { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Controllers
{
    public class CouponGalleryController : Controller
    {
        private readonly MyDbContext myDbContext;
        private readonly ICouponService _couponService;

        public CouponGalleryController(MyDbContext _myDbContext,
                                ICouponService couponService)
        {
            this.myDbContext = _myDbContext;
            this._couponService = couponService;
        }

        [Route("/ma-khuyen-mai")]
        [Route("/ma-khuyen-mai/tags/{tag}")]
        public IActionResult Index(string search, string tag, int page=1)
        {
            CouponGalleryViewModel mdl = new CouponGalleryViewModel();
            var query = _couponService.GetNotDeletedCoupons().OrderByDescending(c => c.CreatedAt).AsQueryable();

            if (!string.IsNullOrEmpty(tag))
            {
                query = _couponService.GetCouponsByType(tag).AsQueryable();
            }
            if (!string.IsNullOrEmpty(search))
            {
                query = _couponService.FindCoupon(search, query);
            }

            mdl.Coupons = query.ToList();
            mdl = PaginationInfo(mdl, page);
            mdl.Coupons = Paging(mdl.Coupons, page);

            return View(mdl);
        }

        [Route("/ma-khuyen-mai/{slug?}")]
        public IActionResult Detail(string slug)
        {
            Coupon coupon = _couponService.WhereSlug(slug, _couponService.GetNotDeletedCoupons()).FirstOrDefault();

            if (coupon != null) return View(coupon);
            else return StatusCode(404);
        }

        const int PAGE_SIZE = 5;
        public IEnumerable<Coupon> Paging(IEnumerable<Coupon> coupons, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            coupons = coupons.Skip(skipN).Take(PAGE_SIZE);
            return coupons;
        }

        public CouponGalleryViewModel PaginationInfo(CouponGalleryViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.Coupons.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}
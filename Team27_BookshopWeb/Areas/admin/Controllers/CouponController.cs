using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class CouponController : Controller
    {
        private readonly MyDbContext _context;
        private readonly ICouponService _couponService;

        public CouponController(MyDbContext context, ICouponService couponService)
        {
            _context = context;
            _couponService = couponService;
        }
        public IActionResult Index(string name, int page=1)
        {

            CouponViewModel mdl = new CouponViewModel();
            if (name != null)
            {
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách coupon";
                mdl.coupons = _couponService.FindCouponName(name);
            }
            else
            {
                mdl.thongBao = "Danh sách coupon";
                mdl.coupons = _couponService.GetNotDeletedCoupons();
            }
            mdl = PaginationInfo(mdl, page);
            mdl.coupons = Paging(mdl.coupons, page);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }
        public IActionResult ShowTmp(string name)
        {
            CouponViewModel mdl = new CouponViewModel();
            if (name != null)
            {
                mdl.coupons = _couponService.FindCouponDeleteName(name);
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách Coupon đã bị tạm xóa";
            }
            else
            {
                mdl.thongBao = "Danh sách Coupon đã tạm xóa";
                mdl.coupons = _couponService.GetDeleteCoupons();
            }
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View("Index", mdl);
        }

        public IActionResult ShowHSD(string name)
        {
            CouponViewModel mdl = new CouponViewModel();
            if (name != null)
            {
                mdl.coupons = _couponService.FindCouponStillExpiryDate(name);
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách Coupon còn HSD";
            }
            else
            {
                mdl.thongBao = "Danh sách Coupon còn HSD";
                mdl.coupons = _couponService.GetCouponStillExpiryDate();
            }
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View("Index", mdl);
        }

        public IActionResult Create()
        {
            CouponEditModel couponEditModel = new CouponEditModel();
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                couponEditModel.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }    
            return View(couponEditModel);

        }
        [HttpPost]
        public IActionResult Create(CouponEditModel couponEditModel, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _couponService.Create(couponEditModel, Image);
                //Gửi thông báo
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
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int id)
        {
            CouponEditModel couponEditModel = new CouponEditModel();
            Coupon cs = _couponService.GetCoupon(id); // entity
            if (cs == null)
            {
                //Gửi thông báo thất bại

                TempData.Put("MessagesView", new MessagesViewModel(false, "coupon không tồn tại"));
                return RedirectToAction("Index");
            }
            couponEditModel = _couponService.CouponToEditModel(cs);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                couponEditModel.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(couponEditModel);
        }

        [HttpPost]
        public IActionResult Edit(CouponEditModel couponEditModel, IFormFile ImageUpLoad)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _couponService.EditCoupon(couponEditModel, ImageUpLoad);
                //Gửi thông báo
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
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Edit");
        }
        public IActionResult Delete(int id)
        {

            MessagesViewModel res = _couponService.DeleteCouponTmp(id);
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

        public IActionResult Restore(int id)
        {
            MessagesViewModel res = _couponService.RestoreCoupon(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("ShowTmp");
            }
            else
            {
                return RedirectToAction("ShowTmp");
            }
        }

        public IActionResult DeleteForever(int id)
        {

            MessagesViewModel res = _couponService.DeleteCouponForever(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("ShowTmp");
            }
            else
            {
                return RedirectToAction("ShowTmp");
            }

        }

        public string CheckSlug(string source, int id)
        {
            return _couponService.CreateSlug(source, id);
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Coupon> Paging(IEnumerable<Coupon> coupons, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            coupons = coupons.Skip(skipN).Take(PAGE_SIZE);
            return coupons;
        }

        public CouponViewModel PaginationInfo(CouponViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.coupons.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }

    }
}

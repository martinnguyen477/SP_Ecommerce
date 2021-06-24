using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface ICouponService
    {
        public CouponEditModel CouponToEditModel(Coupon coupon);
        public Coupon EditModelToCoupon(CouponEditModel couponEditModel, Coupon coupon);

        public IQueryable<Coupon> WhereSlug(string slug, IQueryable<Coupon> coupons);
        public string CreateSlug(string source, int id);
        public IQueryable<Coupon> GetNotDeletedCoupons();
        public IQueryable<Coupon> GetDeleteCoupons();
        public IEnumerable<Coupon> FindCouponName(string name);
        public IEnumerable<Coupon> FindCouponDeleteName(string name);
        public IQueryable<Coupon> FindCoupon(string name, IQueryable<Coupon> coupons);
        public IQueryable<Coupon> GetCouponStillExpiryDate();
        public IEnumerable<Coupon> FindCouponStillExpiryDate(string name);
        public MessagesViewModel Create(CouponEditModel couponEditModel, IFormFile Image);
        public Coupon GetCoupon(int id);
        public IQueryable<Coupon> WhereId(int id, IQueryable<Coupon> coupons);
        public MessagesViewModel EditCoupon(CouponEditModel couponEditModel, IFormFile ImageUpLoad);
        public MessagesViewModel DeleteCouponTmp(int id);
        public MessagesViewModel RestoreCoupon(int id);
        public MessagesViewModel DeleteCouponForever(int id);
        IEnumerable<String> AllTypes();
        IEnumerable<Coupon> GetNewCoupons();
        IQueryable<Coupon> GetCouponsByType(string type);

    }
}
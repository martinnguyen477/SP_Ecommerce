using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class CouponService : ICouponService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        public CouponService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            _booksService = booksService;
        }
        public IQueryable<Coupon> GetCouponsByType(string type)
        {
            return GetNotDeletedCoupons().Where(c => c.Type == type).OrderByDescending(c => c.CreatedAt).AsQueryable();
        }

        //Coupon mới nhât
        public IEnumerable<Coupon> GetNewCoupons()
        {
            return GetNotDeletedCoupons().OrderByDescending(c => c.CreatedAt).ToList();
        }

        //Lấy type coupon
        public IEnumerable<String> AllTypes()
        {
            return myDbContext.Coupons.Select(c => c.Type).Distinct().ToList();
        }


        //Truy vấn theo slug
        public IQueryable<Coupon> WhereSlug(string slug, IQueryable<Coupon> coupons)
        {
            return coupons.Where(c => c.Slug == slug).AsQueryable();
        }

        public string CreateSlug(string source, int id)
        {
            //Tạo slug

            string slug = _booksService.GenerateNewSlug(source);
            IQueryable<Coupon> allCoupons = myDbContext.Coupons;
            //Không đếm slug từ id hiện tại (khi edit publisher)
            if (id != null && id != 0)
            {
                allCoupons = allCoupons.Where(c => c.Id != id).AsQueryable();
            }
            //Đếm slug có tồn tại trong db
            var countSlug = this.WhereSlug(slug, allCoupons).Count();
            //Tồn tại slug trong db
            if (countSlug > 0)
            {
                int checkSlug = countSlug;
                string tmp;
                //Kiểm tra và tạo slug mới
                do
                {
                    tmp = slug + "-" + checkSlug;
                    checkSlug = this.WhereSlug(tmp, allCoupons).Count();
                    countSlug++;
                }
                while (checkSlug > 0);
                slug = tmp;
            }
            return slug;
        }



        public IQueryable<Coupon> GetNotDeletedCoupons()
        {
            return myDbContext.Coupons
                        .Where(p => p.DeletedAt == null)
                        .OrderBy(p => p.Id);
        }

        public IQueryable<Coupon> GetDeleteCoupons()
        {
            return myDbContext.Coupons
                       //Chỉ lấy sách chưa xóa
                       .Where(p => p.DeletedAt != null)
                       //Sắp xếp tăng dần theo Id
                       .OrderBy(p => p.Id);

        }

        public IQueryable<Coupon> GetCouponStillExpiryDate()
        {
            return myDbContext.Coupons
                       //Chỉ lấy sách chưa xóa
                       .Where(p => p.ExpiresAt >= DateTime.Now)
                       //Sắp xếp tăng dần theo Id
                       .OrderBy(p => p.Id);

        }

        public IEnumerable<Coupon> FindCouponStillExpiryDate(string name)
        {
            IEnumerable<Coupon> list = FindCoupon(name, GetCouponStillExpiryDate()).ToList();
            return list;
        }

        public IEnumerable<Coupon> FindCouponName(string name)
        {
            IEnumerable<Coupon> list = FindCoupon(name, GetNotDeletedCoupons()).ToList();
            return list;
        }
        // tim theo danh sách loại sách đã tạm xóa
        public IEnumerable<Coupon> FindCouponDeleteName(string name)
        {
            IEnumerable<Coupon> list = FindCoupon(name, GetDeleteCoupons()).ToList();
            return list;
        }

        public IQueryable<Coupon> FindCoupon(string name, IQueryable<Coupon> coupons)
        {
            return coupons.Where(p => EF.Functions.Like(p.Name, "%" + name + "%")).AsQueryable();
        }

        public MessagesViewModel Create(CouponEditModel couponEditModel, IFormFile Image)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            var tenHinh = "";

            var ktTrungId = myDbContext.Coupons.Where(p => p.Code == couponEditModel.Code).Count();
            if (ktTrungId > 0)
            {
                return new MessagesViewModel(false, "Code này đã tồn tại");
            }
            else
            {
                try
                {
                    Coupon coupon = new Coupon();
                    coupon = EditModelToCoupon(couponEditModel, coupon);

                    if (Image != null)
                    {
                        tenHinh = "Coupon-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(Image.FileName);
                        var urlFull = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "coupon", tenHinh);
                        using (var file = new FileStream(urlFull, FileMode.Create))
                        {
                            Image.CopyTo(file);
                        }
                        coupon.Image = tenHinh;
                    }
                    else
                    {
                        return new MessagesViewModel(false, "chưa có hình ảnh");
                    }

                    coupon.CreatedAt = DateTime.Now;
                    myDbContext.Add(coupon);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "Thêm mới thất bại");
                }
                return new MessagesViewModel(true, "Thành công");
            }

        }

        public Coupon GetCoupon(int id)
        {
            var coupon = WhereId(id, GetNotDeletedCoupons()).FirstOrDefault();
            return coupon;
        }
        public IQueryable<Coupon> WhereId(int id, IQueryable<Coupon> coupons)
        {
            return coupons.Where(p => p.Id == id).AsQueryable();
        }

        public MessagesViewModel EditCoupon(CouponEditModel couponEditModel, IFormFile ImageUpLoad)
        {

            if (!string.IsNullOrEmpty(couponEditModel.Code))
            {
                //ktra khách hàng đã có trong database chưa
                var checkCoupon = WhereId(couponEditModel.Id, GetNotDeletedCoupons()).FirstOrDefault();
                if (checkCoupon != null)
                {
                    var tenHinh = "";

                    try
                    {
                        checkCoupon = EditModelToCoupon(couponEditModel, checkCoupon);

                        if (ImageUpLoad != null)
                        {
                            tenHinh = "Coupon-" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(ImageUpLoad.FileName);
                            var urlFull = Path.Combine(Directory.GetCurrentDirectory(), "Team27StaticFiles", "images", "coupon", tenHinh);
                            using (var file = new FileStream(urlFull, FileMode.Create))
                            {
                                ImageUpLoad.CopyTo(file);
                            }
                            checkCoupon.Image = tenHinh;
                        }

                        myDbContext.Update(checkCoupon);
                        myDbContext.SaveChanges();
                        return new MessagesViewModel(true, "Thành công");
                    }
                    catch (Exception)
                    {

                        return new MessagesViewModel(false, "Không thành công");
                    }


                }
                else
                {
                    return new MessagesViewModel(false, "chưa có coupon trong database");
                }
            }
            else
            {
                return new MessagesViewModel(false, "Không có ID");
            }

        }

        public MessagesViewModel DeleteCouponTmp(int id)
        {

            //ktra khách hàng đã có trong database chưa
            if (id == null || id == 0)
            {
                return new MessagesViewModel(false, "id trống");
            }
            var checkCoupon = WhereId(id, GetNotDeletedCoupons()).FirstOrDefault();
            if (checkCoupon != null)
            {
                try
                {
                    checkCoupon.DeletedAt = DateTime.Now;

                    myDbContext.Update(checkCoupon);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "Không thể đưa vào danh sách");
                }

                return new MessagesViewModel(true, "Đã đưa vào danh sách xóa tạm");
            }
            else
            {
                return new MessagesViewModel(false, "chưa có nxb trong database");

            }
        }

        public MessagesViewModel RestoreCoupon(int id)
        {
            if (id == null || id == 0)
            {
                return new MessagesViewModel(false, "ID trống");
            }

            //ktra khách hàng đã có trong database chưa
            var checkCoupon = WhereId(id, GetDeleteCoupons()).FirstOrDefault();
            if (checkCoupon != null)
            {
                try
                {
                    checkCoupon.DeletedAt = null;

                    myDbContext.Update(checkCoupon);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "không thể restore");
                }

                return new MessagesViewModel(true, "Đã restore");
            }
            else
            {
                return new MessagesViewModel(false, "chua có Coupon trong database");

            }
        }

        public MessagesViewModel DeleteCouponForever(int id)
        {
            if (id == null || id == 0)
            {
                return new MessagesViewModel(false, "id trống");
            }
            // ktra khách hàng đã có trong ds delete tạm chưa
            var checkCoupon = WhereId(id, GetDeleteCoupons()).FirstOrDefault();
            if (checkCoupon != null)
            {
                try
                {
                    myDbContext.Remove(checkCoupon);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {

                    return new MessagesViewModel(false, "Xóa không thành công");
                }

                return new MessagesViewModel(true, "Xóa thành công");
            }
            else
            {
                return new MessagesViewModel(false, "Coupon chưa đc tạm xóa");
            }
        }
        public CouponEditModel CouponToEditModel(Coupon coupon)
        {
            CouponEditModel couponEditModel = new CouponEditModel();
            try
            {
                couponEditModel.Id = coupon.Id;
                couponEditModel.Code = coupon.Code;
                couponEditModel.Name = coupon.Name;
                couponEditModel.Slug = coupon.Slug;
                couponEditModel.Image = coupon.Image;
                couponEditModel.Description = coupon.Description;
                couponEditModel.Uses = coupon.Uses;
                couponEditModel.MaxUses = coupon.MaxUses;
                couponEditModel.MaxUsesUser = coupon.MaxUsesUser;
                couponEditModel.Type = coupon.Type;
                couponEditModel.DiscountAmount = coupon.DiscountAmount;
                couponEditModel.MinPrice = coupon.MinPrice;
                couponEditModel.IsFixed = coupon.IsFixed;
                couponEditModel.StartsAt = coupon.StartsAt;
                couponEditModel.ExpiresAt = coupon.ExpiresAt;
                couponEditModel.CreatedAt = coupon.CreatedAt;
            }
            catch (Exception)
            {
                return null;
            }
            return couponEditModel;
        }

        public Coupon EditModelToCoupon(CouponEditModel couponEditModel, Coupon coupon)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            try
            {
                coupon.Code = couponEditModel.Code;
                coupon.Name = tI.ToTitleCase(tI.ToLower(couponEditModel.Name));
                coupon.Slug = couponEditModel.Slug;
                coupon.Description = couponEditModel.Description;
                coupon.Uses = couponEditModel.Uses;
                coupon.MaxUses = couponEditModel.MaxUses;
                coupon.MaxUsesUser = couponEditModel.MaxUsesUser;
                coupon.Type = couponEditModel.Type;
                coupon.DiscountAmount = couponEditModel.DiscountAmount;
                coupon.MinPrice = couponEditModel.MinPrice;
                coupon.IsFixed = couponEditModel.IsFixed;
                coupon.ExpiresAt = couponEditModel.ExpiresAt;
                coupon.StartsAt = couponEditModel.StartsAt;
                coupon.UpdatedAt = DateTime.Now;
                
                return coupon;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}

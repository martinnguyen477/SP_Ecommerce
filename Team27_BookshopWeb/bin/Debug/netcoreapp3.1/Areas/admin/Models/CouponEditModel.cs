using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class CouponEditModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code không được trống")]
        [DisplayName("Code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Slug không được trống")]
        [DisplayName("Slug")]
        public string Slug { get; set; }

        [Required(ErrorMessage = "Tên không được trống")]
        [DisplayName("Tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mô tả không được trống")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [DisplayName("Số lần sử dụng")]
        public int Uses { get; set; }
        [DisplayName("Số lần sử dụng tối đa")]
        public int MaxUses { get; set; }
        [DisplayName("Số lần sử dụng tối đa/1 khách hàng")]
        public int MaxUsesUser { get; set; }

        [Required(ErrorMessage = "Loại không được trống")]
        [DisplayName("Loại")]
        public string Type { get; set; }
        [DisplayName("Số tiền/ phần trăm giảm giá")]
        public double DiscountAmount { get; set; }
        [DisplayName("Giá tối thiểu")]
        public double MinPrice { get; set; }
        [DisplayName("Giảm theo giá tiền")]
        public int IsFixed { get; set; }
        
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu không được trống")]
        [DisplayName("Ngày bắt đầu")]
        public DateTime StartsAt { get; set; }
        [Required(ErrorMessage = "Ngày hết hạn không được trống")]
        [DisplayName("Ngày hết hạn")]
        public DateTime ExpiresAt { get; set; }

        public MessagesViewModel MessagesView { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Order
    {
        private string _name, _total, _subTotal, _paymentStatus;

        [Required]
        public string Id { get; set; }
        public string CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        //Hiển thị tên
        [NotMapped]
        public string DisplayName
        {
            get
            {
                TextInfo tI = new CultureInfo("en-US", false).TextInfo;
                return tI.ToTitleCase(tI.ToLower(this.Name));
            }
            set
            {
                this._name = value;
            }
        }
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [MaxLength(11)]
        [Phone]
        public string Phone { get; set; }
        public int? CouponId { get; set; }
        public string Note { get; set; }
        public double SubTotal { get; set; }
        //Hiển thị giá tiền
        [NotMapped]
        public string DisplaySubTotal
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.SubTotal.ToString("N0") + " VND";
            }
            set
            {
                this._subTotal = value;
            }
        }
        public double Total { get; set; }
        //Hiển thị giá tiền
        [NotMapped]
        public string DisplayTotal
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.Total.ToString("N0") + " VND";
            }
            set
            {
                this._total = value;
            }
        }
        public int StatusId { get; set; }
        public int PaymentMethodId { get; set; }
        public int PaymentStatus { get; set; }
        [NotMapped]
        public string DisplayPaymentStatus
        {
            get
            {
                switch (this.PaymentStatus)
                {
                    case 1:
                        return "Đã thanh toán";

                    case 2:
                        return "Thanh toán thất bại";

                    default:
                        return "Chưa thanh toán";

                }
            }
            set
            {
                this._paymentStatus = value;
            }
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}

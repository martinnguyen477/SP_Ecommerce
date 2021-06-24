using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class CheckoutViewModel
    {
        private string _subtotal;
        [Required(ErrorMessage = "Tên khách hàng không được trống")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được trống")]
        [Phone]
        public string Phone { get; set; }
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được trống")]
        public string Address { get; set; }
        public string Note { get; set; }
        public string Coupon { get; set; }
        public double SubTotal { get; set; }
        public string DisplaySubtotal
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.SubTotal.ToString("N0") + " VND";
            }
            set
            {
                this._subtotal = value;
            }
        }
        public Cart Cart { get; set; }
        public IEnumerable<CartItems> CartItems { get; set; }
        public MessagesViewModel MessagesView { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class OrderDetail
    {

        private double _total;
        private string _price, _strTotal;
        public int OrderDetailId { get; set; }

        [Required]
        public string OrderId { get; set; }

        [Required]
        public string BookId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        //Hiển thị giá tiền
        [NotMapped]
        public string DisplayPrice
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.Price.ToString("N0") + " VND";
            }
            set
            {
                this._price = value;
            }
        }

        [NotMapped]
        public double Total { 
            get 
            {
                return this.Quantity * this.Price;
            }
            set
            {
                this._total = value;
            }
        }

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
                this._strTotal = value;
            }
        }

        public DateTime CreatedAt { get; set; }

        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }
}

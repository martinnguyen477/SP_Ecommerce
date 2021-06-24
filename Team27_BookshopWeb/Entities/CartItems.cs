using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class CartItems
    {
        private double _total;
        private string _strTotal;

        public int CartId { get; set; }

        [Required]
        public string BookId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int IsSelected { get; set; }
        public DateTime DeletedAt { get; set; }

        [NotMapped]
        public double Total
        {
            get
            {
                return this.Quantity * this.Book.Price;
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

        public virtual Cart Cart { get; set; }
        public virtual Book Book { get; set; }
    }
}

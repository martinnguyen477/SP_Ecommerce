using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            this.Cart = null;
            this.CartItems = Enumerable.Empty<CartItems>();
        }
        public Cart Cart { get; set; }
        public IEnumerable<CartItems> CartItems { get; set; }
        public IEnumerable<Book> ConsideredBooks { get; set; }
        public int Quantity {
            get
            {
                return this.CartItems.Sum(c => c.Quantity);
            }
        }
        public double Total { 
            get
            {
                return this.CartItems.Sum(c => c.Total);
            }
        }

        public string DisplayTotal
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.Total.ToString("N0") + " VND";
            }
        }
    }
}

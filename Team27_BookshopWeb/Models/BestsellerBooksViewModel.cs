using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class BestSellerBooksViewModel
    {
        private string _total, _name;

        [JsonIgnore]
        public Book bestSeller { get; set; }

        public string BookName
        {
            get
            {
                return this.bestSeller.DisplayName;
            }
            set
            {
                _name = value;
            }
        }
        public int numberOfBooks { get; set; }
        public List<double> totalSell { get; set; }
        public int totall { get; set; }

        
        public string DisplayTotalSell
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.totalSell.Sum().ToString("N0") + " VND";
            }
        }
    }
}

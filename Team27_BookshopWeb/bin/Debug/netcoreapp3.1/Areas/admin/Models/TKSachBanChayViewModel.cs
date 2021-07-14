using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class TKSachBanChayViewModel
    {
        public IEnumerable<BestSellerBooksViewModel> listBookBestSell { get; set; }

        public int day { get; set; }

        public string tittle { get; set; }
    }
}

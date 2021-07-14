using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class TKSachViewNhieuViewModel
    {
        public IEnumerable<TopViewModel> listBookBestViewed { get; set; }

        public int day { get; set; }

        public string tittle { get; set; }
    }
}

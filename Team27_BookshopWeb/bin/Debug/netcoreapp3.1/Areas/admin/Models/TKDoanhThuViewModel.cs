using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class TKDoanhThuViewModel
    {
        public IEnumerable<DoanhThuViewModel> listDoanhThu { get; set; }

        public int day { get; set; }

        public string title { get; set; }
    }
}

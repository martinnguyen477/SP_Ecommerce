using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class TKKhachHangViewModel
    {
        public IEnumerable<CustomerStatisticViewModel> listCustomer { get; set; }

        public int day { get; set; }

        public string title { get; set; }
    }
}

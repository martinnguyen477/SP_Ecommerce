using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }

        public int searchtype { get; set; }
        public string filtertype { get; set; }
        public string search { get; set; }
        public int filter { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public MessagesViewModel Noti { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

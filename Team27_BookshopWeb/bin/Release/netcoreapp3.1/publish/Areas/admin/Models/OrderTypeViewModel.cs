using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class OrderTypeViewModel
    {
       // public Order order { get; set; }

        public string OrderTypeName { get; set; }
        
        public int Count { get; set; }
    }
}

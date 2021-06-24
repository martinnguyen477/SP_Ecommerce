using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class ShopViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string search { get; set; }
        public string sort { get; set; }
        public string DisplayBreadcrumb { get; set; }
        public string DisplayPath { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

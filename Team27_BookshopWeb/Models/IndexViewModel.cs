using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Book> newlyPublishedBooks { get; set; }
        public IEnumerable<Book> topViewBooks { get; set; }
        public IEnumerable<Book> bestSellerBooks { get; set; }
        public int countBooks { get; set; }
        public int countCategories { get; set; }
        public Book book { get; set; }
    }
}

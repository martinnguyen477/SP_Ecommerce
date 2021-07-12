using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string search { get; set; }
        public string filtertype { get; set; }
        public string filter { get; set; }
        public MessagesViewModel MessagesView { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

using System.Collections.Generic;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class PublisherViewModel
    {
        public IEnumerable<Publisher> publishers { get; set; }
        public string timKiem { get; set; }
        public string thongBao { get; set; }
        public MessagesViewModel MessagesView { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
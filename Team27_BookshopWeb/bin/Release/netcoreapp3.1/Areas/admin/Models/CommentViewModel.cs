using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class CommentViewModel
    {
        public string timKiem { get; set; }
        public string thongBao { get; set; }
        public string vote { get; set; }
        public string bought { get; set; }
        public IEnumerable<Comment> comments { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }

        public MessagesViewModel MessagesView { get; set; }
    }
}

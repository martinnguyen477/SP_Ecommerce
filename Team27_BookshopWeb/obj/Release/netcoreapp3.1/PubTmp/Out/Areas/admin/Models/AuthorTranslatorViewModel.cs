using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class AuthorTranslatorViewModel
    {
        public IEnumerable<AuthorTranslator> AuthorTranslators { get; set; }
        public string Search { get; set; }
        public string Filter { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

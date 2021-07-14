using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class TopViewModel
    {
        private string _name;
        public Book Book { get; set; }
        public string BookName
        {
            get
            {
                return this.Book.DisplayName;
            }
            set
            {
                _name = value;
            }
        }
        public int Count { get; set; }
    }
}

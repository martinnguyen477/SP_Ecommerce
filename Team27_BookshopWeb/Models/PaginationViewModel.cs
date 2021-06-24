using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class PaginationViewModel
    {
        public PaginationViewModel(int pages, int currentPage)
        {
            this.Pages = pages;
            this.CurrentPage = currentPage;
        }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}

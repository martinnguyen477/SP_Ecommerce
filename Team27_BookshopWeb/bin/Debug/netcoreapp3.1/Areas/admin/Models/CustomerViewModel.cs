using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;


namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> customers { get; set; }

        public string FindCustomer { get; set; }

        public string DeleteCustomer { get; set; }

        public MessagesViewModel MessagesView { get; set; }
        public string search { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}

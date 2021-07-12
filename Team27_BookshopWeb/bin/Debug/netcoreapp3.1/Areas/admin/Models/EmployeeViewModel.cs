using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> employees { get; set; }

        public IEnumerable<string> ChucVu { get; set; }

        public MessagesViewModel MessagesView { get; set; }

        public string name { get; set; }

        public string position { get; set; }
        public int AllPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
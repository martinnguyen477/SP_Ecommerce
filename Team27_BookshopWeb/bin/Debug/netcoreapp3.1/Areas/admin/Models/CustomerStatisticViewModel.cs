using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class CustomerStatisticViewModel
    {
        private string _date;
        public DateTime DateCustomer { get; set; }
        public int Count { get; set; }
        public string DisplayDate
        {
            get
            {
                return this.DateCustomer.ToString("dd/MM/yyyy");
            }
            set{
                this._date = value;
            }
        }

    }
}

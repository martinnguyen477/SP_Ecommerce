using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class DoanhThuViewModel
    {
        private string _date;
        public DateTime DateDoanhThu { get; set; }
        public double Total { get; set; }
        public int ParseTotal
        {
            get
            {
                return Convert.ToInt32(Total);
            }
        }
        public string DisplayDate
        {
            get
            {
                return this.DateDoanhThu.ToString("dd/MM/yyyy");
            }
            set
            {
                this._date = value;
            }
        }
    }
}

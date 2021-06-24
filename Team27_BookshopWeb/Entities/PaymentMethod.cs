using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class PaymentMethod
    {
        private string _isSupported;
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int IsSupported { get; set; }

        //Hiển thị tên
        [NotMapped]
        public string DisplayName
        {
            get
            {
                return (this.IsSupported == 1) ? "Hỗ trợ" : "Không hỗ trợ";
            }
            set
            {
                this._isSupported = value;
            }
        }

        public virtual ICollection<Order> Orders { get; set; }
        public PaymentMethod()
        {
            Orders = new HashSet<Order>();
        }
    }
}

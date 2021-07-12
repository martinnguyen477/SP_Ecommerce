using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class PaymentMethodEditModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên")]
        [DisplayName("Tên phương thức thanh toán")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tình trạng")]
        [DisplayName("Tình trạng")]
        public int IsSupported { get; set; }

        public MessagesViewModel MessagesView { get; set; }
    }
}

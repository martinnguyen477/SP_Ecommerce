using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class PaymentMethodViewModel
    {
        public IEnumerable<PaymentMethod> payments { get; set; }

        public string filter { get; set; }

        public MessagesViewModel MessagesView { get; set; }
    }
}
